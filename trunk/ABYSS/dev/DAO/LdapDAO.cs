using System;
using Utils;
using System.DirectoryServices;

namespace DAO {
    public class LdapDAO {
        #region Attributes
        private static DirectoryEntry root = null; // the current connection
        #endregion

        #region Properties
        public static DirectoryEntry Root{
            get { return root; }
            set { root = value; }
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Returns the current directory Entry root.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static DirectoryEntry getLdapConnection(string path, string username, string password) {
            root = Utility.connection(path, username, password);
            return root;
        }

        /// <summary>
        /// Returns the current directory Entry root.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static DirectoryEntry getLdapConnection(string username, string password){
            root = Utility.connection(username,password);
            return root;
        }
        
        /// <summary>
        /// Cancel he current directory Entry root.
        /// </summary>
        public static void setInitToFalse(){
            Utility.InitFinish = false;
            root = null;
        }
        #endregion
    }
}