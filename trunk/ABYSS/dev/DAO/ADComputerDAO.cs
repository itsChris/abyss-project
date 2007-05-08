using System;
using Persistence;
using Utils;
using System.Collections;
using System.DirectoryServices;

namespace DAO {
    public class ADComputerDAO : LdapDAO{
        #region Static Methods
        #region Private
        private static ADComputerData adComputerDataMapping(DirectoryEntry directoryEntry) {
            ADComputerData adComputerData = new ADComputerData();
            adComputerData.ComputerName = Utility.getProperty(directoryEntry, "sAMAccountName");
            if (adComputerData.ComputerName.EndsWith("$")) {
                String computerName = adComputerData.ComputerName.Remove(adComputerData.ComputerName.Length - 1);
                adComputerData.ComputerName = computerName;
            }
            adComputerData.Description = Utility.getProperty(directoryEntry, "description");
            adComputerData.DnsName = Utility.getProperty(directoryEntry, "dNSHostName");
            adComputerData.DistinguishedName = Utility.getProperty(directoryEntry, "distinguishedName");
            adComputerData.Memberof = getMemberOfList(adComputerData.DistinguishedName);
            adComputerData.OperatingSystem = Utility.getProperty(directoryEntry, "operatingSystem");
            adComputerData.OperatingSystemServicePack = Utility.getProperty(directoryEntry, "operatingSystemServicePack");
            adComputerData.OperatingSystemVersion = Utility.getProperty(directoryEntry, "operatingSystemVersion");
            int userAccountControl = Convert.ToInt32(Utility.getProperty(directoryEntry, "userAccountControl"));
            adComputerData.Enabled = false;
            if (Utility.isAccountActive(userAccountControl)) {
                adComputerData.Enabled = true;
            }
            if (Utility.isComputerWorkStationAccount(userAccountControl)) {
                adComputerData.Role = ADComputerData.Computer.WORKSTATION_TRUST_ACCOUNT;
            }
            else{
                adComputerData.Role = ADComputerData.Computer.SERVER_TRUST_ACCOUNT;
            }
            adComputerData.TrustForDelegation = false;
            if (Utility.isComputerTrustedDelegation(userAccountControl)) {
                adComputerData.TrustForDelegation = true;
            }          
            return adComputerData;
        }

        private static ArrayList getComputersList(SearchResultCollection searchResultCollection) {
            ArrayList list = new ArrayList();
            foreach (SearchResult searchResult in searchResultCollection) {
                ADComputerData aDComputerData = adComputerDataMapping(new DirectoryEntry(searchResult.Path, Utility.CrtUserName, Utility.CrtPassword));
                list.Add(aDComputerData);
            }
            return list;
        }

        private static void save(ADComputerData aDComputerData) {
            bool update = true;
            DirectoryEntry entry = getInstance();
            DirectoryEntry directoryEntry = Utility.getComputer(aDComputerData.ComputerName);
            if (directoryEntry == null) {
                DirectoryEntries directoryEntries = entry.Children;
                directoryEntry = directoryEntries.Add("cn=" + aDComputerData.ComputerName + ",cn=computers", "computer");
                update = false;
            }
            Utility.setProperty(directoryEntry, "sAMAccountName", aDComputerData.ComputerName);
            Utility.setProperty(directoryEntry, "description", aDComputerData.Description);
            if (update) {
                aDComputerData.DistinguishedName = Utility.getProperty(directoryEntry, "distinguishedName");
                updateMemberOfList(aDComputerData, directoryEntry);
            }
            Utility.setProperty(directoryEntry, "operatingSystem", aDComputerData.OperatingSystem);
            Utility.setProperty(directoryEntry, "operatingSystemServicePack", aDComputerData.OperatingSystemServicePack);
            Utility.setProperty(directoryEntry, "operatingSystemVersion", aDComputerData.OperatingSystemVersion);
            int userAccountControl;
            if (aDComputerData.Role == ADComputerData.Computer.WORKSTATION_TRUST_ACCOUNT) {
                userAccountControl = Convert.ToInt32(Utility.ADS_USER_FLAG_ENUM.ADS_UF_WORKSTATION_TRUST_ACCOUNT);
            }
            else {
                userAccountControl = Convert.ToInt32(Utility.ADS_USER_FLAG_ENUM.ADS_UF_SERVER_TRUST_ACCOUNT);
            }
            if (aDComputerData.Enabled) {
                userAccountControl += Convert.ToInt32(Utility.ADS_USER_FLAG_ENUM.ADS_UF_PASSWD_NOTREQD);
            }
            else {
                userAccountControl += Convert.ToInt32(Utility.ADS_USER_FLAG_ENUM.ADS_UF_ACCOUNTDISABLE);
            }
            if (aDComputerData.TrustForDelegation) {
                userAccountControl += Convert.ToInt32(Utility.ADS_USER_FLAG_ENUM.ADS_UF_TRUSTED_FOR_DELEGATION);
            }
            directoryEntry.Properties["userAccountControl"].Value = userAccountControl;
            directoryEntry.CommitChanges();
            directoryEntry.Close();
        }

        private static void updateMemberOfList(ADComputerData adComputerData, DirectoryEntry directoryEntry) {
            ArrayList list = getMemberOfList(adComputerData.DistinguishedName);
            foreach (String distinguishedName in list) {
                DirectoryEntry memberOf = Utility.getDirectoryObjectByDistinguishedName(distinguishedName);
                try{
                Utility.removeProperty(memberOf, "Member", adComputerData.DistinguishedName);
                memberOf.CommitChanges();
                memberOf.Close();
                }
                catch(Exception){
                }
            }
            foreach (String distinguishedName in adComputerData.Memberof) {
                DirectoryEntry memberOf = Utility.getDirectoryObjectByDistinguishedName(distinguishedName);
                try {
                    Utility.setProperty(memberOf, "Member", adComputerData.DistinguishedName);
                    memberOf.CommitChanges();
                    memberOf.Close();
                }
                catch (Exception) {
                }
            }
        }

        private static ArrayList getMemberOfList(string DistinguishedName) {
            int index;
            DirectoryEntry de = Utility.getDirectoryObjectByDistinguishedName(DistinguishedName);
            ArrayList list = new ArrayList();
            for (index = 0; index <= de.Properties["memberOf"].Count - 1; index++) {
                DirectoryEntry temp = Utility.getDirectoryObjectByDistinguishedName(getInstance().Path + "/" + de.Properties["memberOf"][index].ToString());
                list.Add(Utility.getProperty(temp, "distinguishedName"));
            }
            de.Close();
            return list;
        }
        #endregion

        #region Public
        public static ADComputerData getComputerByName(string computerName) {
            DirectoryEntry directoryEntry = Utility.getComputer(computerName);
            if (directoryEntry != null) {
                return adComputerDataMapping(directoryEntry);
            }
            return null;
        }

        public static ArrayList getComputersList() {
            return getComputersList(Utility.getComputers());
        }

        public static void saveComputer(ADComputerData aDComputerData) {
            save(aDComputerData);
        }

        public static void deleteUserAccount(string ComputerName) {
            DirectoryEntry directoryEntry = Utility.getComputer(ComputerName);
            directoryEntry.DeleteTree();
            directoryEntry.CommitChanges();
            directoryEntry.Close();
        }

        public static void disableComputerAccount(string ComputerName, ADComputerData.Computer Role) {
            int userAccountControl = Convert.ToInt32(Utility.ADS_USER_FLAG_ENUM.ADS_UF_ACCOUNTDISABLE);
            if (Role == ADComputerData.Computer.WORKSTATION_TRUST_ACCOUNT) {
                userAccountControl += Convert.ToInt32(Utility.ADS_USER_FLAG_ENUM.ADS_UF_WORKSTATION_TRUST_ACCOUNT);
            }
            else {
                userAccountControl += Convert.ToInt32(Utility.ADS_USER_FLAG_ENUM.ADS_UF_SERVER_TRUST_ACCOUNT);
            }
            DirectoryEntry entry = Utility.getComputer(ComputerName);
            entry.Properties["userAccountControl"].Value = userAccountControl;
            entry.CommitChanges();
            entry.Close();
        }

        public static void enableComputerAccount(string ComputerName, ADComputerData.Computer Role) {
            int userAccountControl = Convert.ToInt32(Utility.ADS_USER_FLAG_ENUM.ADS_UF_PASSWD_NOTREQD);
            if (Role == ADComputerData.Computer.WORKSTATION_TRUST_ACCOUNT) {
                userAccountControl += Convert.ToInt32(Utility.ADS_USER_FLAG_ENUM.ADS_UF_WORKSTATION_TRUST_ACCOUNT);
            }
            else {
                userAccountControl += Convert.ToInt32(Utility.ADS_USER_FLAG_ENUM.ADS_UF_SERVER_TRUST_ACCOUNT);
            }
            DirectoryEntry entry = Utility.getComputer(ComputerName);
            entry.Properties["userAccountControl"].Value = userAccountControl;
            entry.CommitChanges();
            entry.Close();
        }
        #endregion
        #endregion      
    }
}
