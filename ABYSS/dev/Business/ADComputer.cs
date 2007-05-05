using System;
using Persistence;
using DAO;
using System.Collections;

namespace Business {
    public class ADComputer {
        #region Attributes
        private ADComputerData adComputerData;
        #endregion
       
        #region Enunumeration
        public enum Computer {
            WORKSTATION_TRUST_ACCOUNT,
            SERVER_TRUST_ACCOUNT
        }
        #endregion

        #region Constructor
        public ADComputer() {
            this.adComputerData = new ADComputerData();
        }

        public ADComputer(ADComputerData adComputerData) {
            this.adComputerData = adComputerData;
        }
        #endregion

        #region Properties
        public string ComputerName {
            get { return adComputerData.ComputerName; }
            set { adComputerData.ComputerName = value; }
        }

        public string DnsName {
            get { return adComputerData.DnsName; }
            set { adComputerData.DnsName = value; }
        }

        public ADComputerData.Computer Role {
            get { return adComputerData.Role; }
            set { adComputerData.Role = value; }
        }

        public string Description {
            get { return adComputerData.Description; }
            set { adComputerData.Description = value; }
        }

        public bool TrustForDelegation {
            get { return adComputerData.TrustForDelegation; }
            set { adComputerData.TrustForDelegation = value; }
        }

        public string OperatingSystem {
            get { return adComputerData.OperatingSystem; }
            set { adComputerData.OperatingSystem = value; }
        }

        public string OperatingSystemVersion {
            get { return adComputerData.OperatingSystemVersion; }
            set { adComputerData.OperatingSystemVersion = value; }
        }

        public string OperatingSystemServicePack {
            get { return adComputerData.OperatingSystemServicePack; }
            set { adComputerData.OperatingSystemServicePack = value; }
        }

        public ArrayList Memberof {
            get { return adComputerData.Memberof; }
            set { adComputerData.Memberof = value; }
        }

        public bool Enabled {
            get { return adComputerData.Enabled; }
            set { adComputerData.Enabled = value; }
        }
        #endregion 

        #region Static Methods
        public static ADComputer getComputerByName(string computerName) {
            ADComputerData adComputerData = ADComputerDAO.getComputerByName(computerName);
            if (adComputerData != null) {
                return new ADComputer((ADComputerData)adComputerData);
            }
            return null;
        }

        public static ArrayList getComputersList() {
            return ADComputerDAO.getComputersList();
        }
        #endregion

        #region Public Methods
        public void save() {
            ADComputerDAO.saveComputer(this.adComputerData);
        }

        public void disableComputerAccount() {
            ADComputerDAO.disableComputerAccount(ComputerName);
        }

        public void enableComputerAccount() {
            ADComputerDAO.enableComputerAccount(ComputerName);
        }

        public void deleteComputerAccount() {
            ADUserDAO.deleteUserAccount(ComputerName);
        }
        #endregion
    }
}
