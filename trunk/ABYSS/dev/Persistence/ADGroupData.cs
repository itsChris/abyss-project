using System;

namespace Persistence {
    [Serializable]public class ADGroupData {
        #region Attributes
        private string name; //(cn ) in Active Directory
        private string displayName;
        private string distinguishedName;
        private string description;
        #endregion

        #region Constructors
        public ADGroupData() {
        }
        #endregion

        #region Properties
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string DisplayName {
            get { return displayName; }
            set { displayName = value; }
        }

        public string DistinguishedName {
            get { return distinguishedName; }
            set { distinguishedName = value; }
        }

        public string Description {
            get { return description; }
            set { description = value; }
        }
        #endregion
    }
}
