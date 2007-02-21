namespace Abyss_Client.CompBase
{
    partial class BaseMenuStrip
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // toolStripMenuItemNew
            // 
            this.toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            this.toolStripMenuItemNew.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItemNew.Text = "New...";
            // 
            // toolStripMenuItemConnect
            // 
            this.toolStripMenuItemConnect.Name = "toolStripMenuItemConnect";
            this.toolStripMenuItemConnect.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItemConnect.Text = "Connect to...";
            // 
            // toolStripMenuItemDisconnect
            // 
            this.toolStripMenuItemDisconnect.Name = "toolStripMenuItemDisconnect";
            this.toolStripMenuItemDisconnect.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItemDisconnect.Text = "Disconnect";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItemExit.Text = "Quit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConnect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDisconnect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;

    }
}
