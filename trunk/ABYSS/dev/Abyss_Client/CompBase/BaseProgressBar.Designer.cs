namespace Abyss_Client.CompBase {
    partial class BaseProgressBar {
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // BaseProgressBar
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.BarOffset = 0;
            this.Caption = "<PERCENTAGE>% Completed";
            this.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.Custom;
            this.CaptionShadowColor = System.Drawing.SystemColors.GrayText;
            this.DashSpace = 1;
            this.DashWidth = 1;
            this.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.None;
            this.EdgeWidth = 0;
            this.FloodPercentage = 0.5F;
            this.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Horizontal;
            this.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Name = "BaseProgressBar";
            this.ProgressBackColor = System.Drawing.Color.Transparent;
            this.Value = 100;
            this.ResumeLayout(false);

        }

        #endregion
    }
}
