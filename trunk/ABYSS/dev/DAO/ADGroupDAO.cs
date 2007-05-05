using System;
using Persistence;
using Utils;
using System.Collections;
using System.DirectoryServices;

namespace DAO {
    public class ADGroupDAO : LdapDAO {
        #region Static Methods
        #region Private
        private static ADGroupData adGroupDataMapping(DirectoryEntry directoryEntry) {
            ADGroupData adGroupData = new ADGroupData();
            adGroupData.Name = Utility.getProperty(directoryEntry, "sAMAccountName");
            adGroupData.Description = Utility.getProperty(directoryEntry, "description");
            adGroupData.DistinguishedName = Utility.getProperty(directoryEntry, "distinguishedName");
            adGroupData.Members = getMembersList(adGroupData.DistinguishedName);
            adGroupData.Memberof = getMemberOfList(adGroupData.DistinguishedName);
            int groupeScope = Convert.ToInt32(Utility.getProperty(directoryEntry, "groupType"));
            if (Utility.isGlobalScope(groupeScope)) {
                adGroupData.Scope = ADGroupData.GroupeScope.Global;
            }
            else if (Utility.isDomainLocalScope(groupeScope)) {
                adGroupData.Scope = ADGroupData.GroupeScope.DomainLocal;
            }
            else {
                adGroupData.Scope = ADGroupData.GroupeScope.Universel;
            }
            adGroupData.SecurityGroupe = false;
            if (Utility.isSecurityEnable(Convert.ToInt64(Utility.getProperty(directoryEntry, "groupType")))) {
                adGroupData.SecurityGroupe = true;
            }
            return adGroupData;
        }

        private static ArrayList getGroupsList(SearchResultCollection searchResultCollection) {
            ArrayList list = new ArrayList();
            foreach (SearchResult searchResult in searchResultCollection) {
                ADGroupData aDGroupData = adGroupDataMapping(new DirectoryEntry(searchResult.Path, Utility.CrtUserName, Utility.CrtPassword));
                list.Add(aDGroupData);
            }
            return list;
        }

        private static void save(ADGroupData aDGroupData) {
            DirectoryEntry entry = getInstance();
            DirectoryEntry directoryEntry = Utility.getGroup(aDGroupData.Name);
            if (directoryEntry == null) {
                DirectoryEntries directoryEntries = entry.Children;
                directoryEntry = directoryEntries.Add("cn=" + aDGroupData.Name + ",cn=users", "group");
            }
            Utility.setProperty(directoryEntry, "sAMAccountName", aDGroupData.Name);
            Utility.setProperty(directoryEntry, "description", aDGroupData.Description);
            updateMembersAndMemberOfList(aDGroupData, directoryEntry);
            long group;
            if(aDGroupData.Scope == ADGroupData.GroupeScope.Global){
                group = Convert.ToInt64(Utility.ADS_GROUP_TYPE_ENUM.ADS_GROUP_TYPE_GLOBAL_GROUP);
            }
            else if(aDGroupData.Scope == ADGroupData.GroupeScope.DomainLocal){
                group = Convert.ToInt64(Utility.ADS_GROUP_TYPE_ENUM.ADS_GROUP_TYPE_DOMAIN_LOCAL_GROUP);
            }
            else{
                group = Convert.ToInt64(Utility.ADS_GROUP_TYPE_ENUM.ADS_GROUP_TYPE_UNIVERSAL_GROUP);
            }
            if(aDGroupData.SecurityGroupe){
                group+= Convert.ToInt64(Utility.ADS_GROUP_TYPE_ENUM.ADS_GROUP_TYPE_SECURITY_ENABLED);
            }
            Utility.setProperty(directoryEntry, "groupType", group+"");
            directoryEntry.CommitChanges();
            directoryEntry.Close();
        }

        private static void updateMembersAndMemberOfList(ADGroupData adGroupData, DirectoryEntry directoryEntry) {
            ArrayList list = getMembersList(adGroupData.DistinguishedName);
            foreach (String distinguishedName in list) {
                Utility.removeProperty(directoryEntry, "Member", distinguishedName);
            }
            foreach (String distinguishedName in adGroupData.Members) {
                Utility.setProperty(directoryEntry, "Member", distinguishedName);
            }
            list = getMemberOfList(adGroupData.DistinguishedName);
            foreach (String distinguishedName in list) {
                DirectoryEntry memberOf = Utility.getDirectoryObjectByDistinguishedName(distinguishedName);
                Utility.removeProperty(memberOf, "Member", adGroupData.DistinguishedName);
                memberOf.CommitChanges();
                memberOf.Close();
            }
            foreach (String distinguishedName in adGroupData.Memberof) {
                DirectoryEntry memberOf = Utility.getDirectoryObjectByDistinguishedName(distinguishedName);
                Utility.setProperty(memberOf, "Member", adGroupData.DistinguishedName);
                memberOf.CommitChanges();
                memberOf.Close();
            }
        }

        private static ArrayList getMembersList(string DistinguishedName) {
            int index;
            DirectoryEntry de = Utility.getDirectoryObjectByDistinguishedName(DistinguishedName);
            ArrayList list = new ArrayList();
            for (index = 0; index <= de.Properties["member"].Count - 1; index++) {
                DirectoryEntry temp = Utility.getDirectoryObjectByDistinguishedName(getInstance().Path + "/" + de.Properties["member"][index].ToString());
                list.Add(Utility.getProperty(temp, "distinguishedName"));
            }
            de.Close();
            return list;
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
        public static ADGroupData getGroup(string groupName) {
            DirectoryEntry directoryEntry = Utility.getGroup(groupName);
            if (directoryEntry != null) {
                return adGroupDataMapping(directoryEntry);
            }
            return null;
        }

        public static ArrayList getGroupsList() {
            return getGroupsList(Utility.getGroups());
        }

        public static void saveGroup(ADGroupData aDGroupData) {
            save(aDGroupData);
        }

        public static void deleteGroup(string name) {
            DirectoryEntry directoryEntry = Utility.getGroup(name);
            directoryEntry.DeleteTree();
            directoryEntry.CommitChanges();
            directoryEntry.Close();
        }
        #endregion
        #endregion
    }
}

