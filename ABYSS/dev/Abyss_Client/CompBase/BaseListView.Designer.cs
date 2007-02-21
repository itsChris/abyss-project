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
            this.CHeader_Name = new System.Windows.Forms.ColumnHeader();
            this.CHeader_Type = new System.Windows.Forms.ColumnHeader();
            this.CHeader_Description = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // CHeader_Name
            // 
            this.CHeader_Name.Text = "Name";
            this.CHeader_Name.Width = 256;
            // 
            // CHeader_Type
            // 
            this.CHeader_Type.Text = "Type";
            this.CHeader_Type.Width = 166;
            // 
            // CHeader_Description
            // 
            this.CHeader_Description.Text = "Description";
            this.CHeader_Description.Width = 266;
            // 
            // BaseListView
            // 
            this.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHeader_Name,
            this.CHeader_Type,
            this.CHeader_Description});
            this.Size = new System.Drawing.Size(692, 526);
            this.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader CHeader_Name;
        private System.Windows.Forms.ColumnHeader CHeader_Type;
        private System.Windows.Forms.ColumnHeader CHeader_Description;
    }
}
