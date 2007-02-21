using System;
using System.Threading;

namespace Abyss_Client {
    class SingleInstanceApp : IDisposable{

        Mutex _siMutex;
        bool _siMutexOwned;

        public SingleInstanceApp(string name) {
            _siMutex = new Mutex(false, name);
            _siMutexOwned = false;
        }

        public bool IsRunning() {
            _siMutexOwned = _siMutex.WaitOne(0, true);
            return !(_siMutexOwned);
        }

        public void Dispose() {
            if (_siMutexOwned)
                _siMutex.ReleaseMutex();
        }
    }
}
