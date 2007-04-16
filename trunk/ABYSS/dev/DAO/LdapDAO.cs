using System;
using Utils;
using System.DirectoryServices;

namespace DAO {
    public class LdapDAO {
        #region Attributes
        private static DirectoryEntry instance = null; // the current connection
        #endregion

        #region Constructors
        /// <summary>
        /// Protected Singleton
        /// </summary>
        protected LdapDAO() { }
        #endregion

        #region Static Methods
        /// <summary>
        /// Set the current directory Entry root.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static void setLdapConnection(string path, string username, string password) {
            instance = Utility.connection(path, username, password);
        }

        /// <summary>
        /// Set the current directory Entry root.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static void setLdapConnection(string username, string password){
            instance = Utility.connection(username,password);
        }

        /// <summary>
        /// Return the cuurent instance
        /// </summary>
        /// <returns></returns>
        public static DirectoryEntry getInstance() {
            return instance;
        }
        
        /// <summary>
        /// Cancel the current directory Entry root.
        /// </summary>
        public static void setInitToFalse(){
            Utility.InitFinish = false;
            instance = null;
        }
        #endregion
    }
}