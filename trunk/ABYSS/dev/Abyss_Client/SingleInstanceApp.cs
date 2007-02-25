using System;
using System.Threading;

namespace Abyss_Client {
    class SingleInstanceApp : IDisposable {
        #region Attributes
        Mutex siMutex;
        bool siMutexOwned;
        #endregion

        #region Constructors
        public SingleInstanceApp(string name) {
            siMutex = new Mutex(false, name);
            siMutexOwned = false;
        }
        #endregion

        #region Public Methods
        public bool IsRunning() {
            siMutexOwned = siMutex.WaitOne(0, true);
            return !(siMutexOwned);
        }

        public void Dispose() {
            if (siMutexOwned)
                siMutex.ReleaseMutex();
        }
        #endregion
    }
}
