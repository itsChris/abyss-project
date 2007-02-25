namespace Abyss_Client.CompBase
{
    partial class BaseListView
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
            this.SuspendLayout();
            // 
            // BaseListView
            // 
            this.AllowColumnReorder = true;
            this.FullRowSelect = true;
            this.MultiSelect = false;
            this.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.TabStop = false;
            this.View = System.Windows.Forms.View.Details;
            this.ResumeLayout(false);

        }
        #endregion
    }
}
