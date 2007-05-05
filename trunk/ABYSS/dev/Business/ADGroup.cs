using System;
using DAO;
using Persistence;
using System.Collections;
using System.DirectoryServices;

namespace Business {
    public class ADGroup {
        #region Attributes
        private ADGroupData aDGroupData;
        #endregion

        #region enum
        public enum GroupeScope {
            Global,
            DomainLocal,
            Universel
        }
        #endregion

        #region Constructors
        public ADGroup() {
            this.aDGroupData = new ADGroupData();
        }

        public ADGroup(ADGroupData aDGroupData) {
            this.aDGroupData = aDGroupData;
        }
        #endregion

        #region Properties
        public string Name {
            get { return aDGroupData.Name; }
            set { aDGroupData.Name = value; }
        }

        public string DistinguishedName {
            get { return aDGroupData.DistinguishedName; }
            set { aDGroupData.DistinguishedName = value; }
        }

        public bool SecurityGroupe {
            get { return aDGroupData.SecurityGroupe; }
            set { aDGroupData.SecurityGroupe = value; }
        }

        public ADGroupData.GroupeScope Scope {
            get { return aDGroupData.Scope; }
            set { aDGroupData.Scope = value; }
        }

        public string Description {
            get { return aDGroupData.Description; }
            set { aDGroupData.Description = value; }
        }

        public ArrayList Members {
            get { return aDGroupData.Members; }
            set { aDGroupData.Members = value; }
        }

        public ArrayList Memberof {
            get { return aDGroupData.Memberof; }
            set { aDGroupData.Memberof = value; }
        }
        #endregion

        #region Static Methods
        public static ADGroup getGroupByName(string groupName) {
            ADGroupData aDGroupData = ADGroupDAO.getGroup(groupName);
            if (aDGroupData != null) {
                return new ADGroup((ADGroupData)aDGroupData);
            }
            return null;
        }

        public static ArrayList getGroupsList() {
            return ADGroupDAO.getGroupsList();
        }
        #endregion

        #region Public Methods
        public void save() {
            ADGroupDAO.saveGroup(this.aDGroupData);
        }

        public void deleteGroup() {
            ADGroupDAO.deleteGroup(Name);
        }
        #endregion
    }
}
