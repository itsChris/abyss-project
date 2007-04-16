namespace Abyss_Client.CompBase {
    partial class BaseTextBox {
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
            // BaseTextBox
            // 
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.BaseTextBox_Validating);
            this.TextChanged += new System.EventHandler(this.BaseTextBox_TextChanged);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
