﻿namespace Abyss_Client {
    partial class SplashScreen {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.clientLogo_pct = new Abyss_Client.CompBase.BasePictureBox();
            this.timer_tmr = new Abyss_Client.CompBase.BaseTimer();
            this.prgBar_pgb = new ExtendedDotNET.Controls.Progress.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.clientLogo_pct)).BeginInit();
            this.SuspendLayout();
            // 
            // clientLogo_pct
            // 
            this.clientLogo_pct.BackColor = System.Drawing.Color.Transparent;
            this.clientLogo_pct.BackgroundImage = global::Abyss_Client.Properties.Resources.splash;
            this.clientLogo_pct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clientLogo_pct.Location = new System.Drawing.Point(-5, 1);
            this.clientLogo_pct.Name = "clientLogo_pct";
            this.clientLogo_pct.Size = new System.Drawing.Size(636, 348);
            this.clientLogo_pct.TabIndex = 0;
            this.clientLogo_pct.TabStop = false;
            // 
            // timer_tmr
            // 
            this.timer_tmr.Enabled = true;
            this.timer_tmr.Interval = 10;
            this.timer_tmr.Tick += new System.EventHandler(this.timer_tmr_Tick);
            // 
            // prgBar_pgb
            // 
            this.prgBar_pgb.BackColor = System.Drawing.Color.Lavender;
            this.prgBar_pgb.BarOffset = 1;
            this.prgBar_pgb.Caption = "<PERCENTAGE>% Completed";
            this.prgBar_pgb.CaptionColor = System.Drawing.Color.Black;
            this.prgBar_pgb.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.Custom;
            this.prgBar_pgb.CaptionShadowColor = System.Drawing.SystemColors.GrayText;
            this.prgBar_pgb.ChangeByMouse = false;
            this.prgBar_pgb.DashSpace = 2;
            this.prgBar_pgb.DashWidth = 5;
            this.prgBar_pgb.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.Rounded;
            this.prgBar_pgb.EdgeColor = System.Drawing.Color.Gray;
            this.prgBar_pgb.EdgeLightColor = System.Drawing.Color.LightGray;
            this.prgBar_pgb.EdgeWidth = 0;
            this.prgBar_pgb.FloodPercentage = 0.2F;
            this.prgBar_pgb.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Horizontal;
            this.prgBar_pgb.Invert = false;
            this.prgBar_pgb.Location = new System.Drawing.Point(210, 272);
            this.prgBar_pgb.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.prgBar_pgb.Maximum = 100;
            this.prgBar_pgb.Minimum = 0;
            this.prgBar_pgb.Name = "prgBar_pgb";
            this.prgBar_pgb.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.prgBar_pgb.ProgressBackColor = System.Drawing.Color.Transparent;
            this.prgBar_pgb.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Dashed;
            this.prgBar_pgb.SecondColor = System.Drawing.Color.White;
            this.prgBar_pgb.Shadow = true;
            this.prgBar_pgb.ShadowOffset = 1;
            this.prgBar_pgb.Size = new System.Drawing.Size(229, 24);
            this.prgBar_pgb.Step = 2;
            this.prgBar_pgb.TabIndex = 2;
            this.prgBar_pgb.TextAntialias = true;
            this.prgBar_pgb.Value = 0;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 373);
            this.Controls.Add(this.prgBar_pgb);
            this.Controls.Add(this.clientLogo_pct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = false;
            this.Name = "SplashScreen";
            this.Text = "SplashScreen";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientLogo_pct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Abyss_Client.CompBase.BasePictureBox clientLogo_pct;
        private Abyss_Client.CompBase.BaseTimer timer_tmr;
        private ExtendedDotNET.Controls.Progress.ProgressBar prgBar_pgb;
    }
}