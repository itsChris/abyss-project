using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Abyss_Client.CompBase;
using System.Threading;

namespace Abyss_Client {
    public partial class SplashScreen : Form {
        #region Attributes
        private bool loadFinished = false;
        #endregion

        #region Constructors
        public SplashScreen() {
            InitializeComponent();
        }
        #endregion

        #region Component events
        private void SplashScreen_Load(object sender, EventArgs e) {
            Thread trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            trd.Start();
        }

        private void ThreadTask() {
            while (!loadFinished) {
                if (prgBar_pgb.Value == prgBar_pgb.Maximum) {
                    loadFinished = true;
                }
            }
        }

        private void timer_tmr_Tick(object sender, EventArgs e) {
            if (prgBar_pgb.Value >= prgBar_pgb.Maximum) {
                prgBar_pgb.Value = prgBar_pgb.Minimum;
            }
            prgBar_pgb.PerformStep();
            prgBar_pgb.Invalidate();
            if (loadFinished) {
               timer_tmr.Stop();
                this.Close();
            }
        }
        #endregion
        
    }

}