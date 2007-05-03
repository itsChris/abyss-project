using System;
using System.Collections;

namespace Persistence {
    [Serializable]public class ADGroupData {
        #region Attributes
        private string name;
        private string distinguishedName;
        private string description;
        private GroupeScope scope;
        private bool securityGroupe;
        #endregion

        #region Enum
        public enum GroupeScope {
            Global,
            DomainLocal,
            Universel
        }
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

        public string DistinguishedName {
            get { return distinguishedName; }
            set { distinguishedName = value; }
        }

        public bool SecurityGroupe {
            get { return securityGroupe; }
            set { securityGroupe = value; }
        }

        public GroupeScope Scope {
            get { return scope; }
            set { scope = value; }
        }

        public string Description {
            get { return description; }
            set { description = value; }
        }
        #endregion
    }
}
