using System;

namespace Persistence {
    [Serializable] public class ADComputerData {
        #region Attributes
        private string computerName;
        private string DNSName;
        private Computer role;
        private string description;
        private bool trustForDelegation;
        private string operatingSystem;
        private string operatingSystemVersion;
        private string operatingSystemServicePack;


        #endregion
       

        #region Enunumeration
        public enum Computer {
            WORKSTATION_TRUST_ACCOUNT,
            SERVER_TRUST_ACCOUNT
        }
        #endregion
    }

  
}
