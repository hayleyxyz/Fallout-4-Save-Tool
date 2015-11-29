namespace f4st.Fragments {
    partial class IdBlocksFragment {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.idBlocksList = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.idBlocksListContextMenu = new System.Windows.Forms.ContextMenu();
            this.idBlocksExtractMenuItem = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.idBlocksList)).BeginInit();
            this.SuspendLayout();
            // 
            // idBlocksList
            // 
            this.idBlocksList.AllColumns.Add(this.olvColumn1);
            this.idBlocksList.AllColumns.Add(this.olvColumn2);
            this.idBlocksList.AllColumns.Add(this.olvColumn3);
            this.idBlocksList.CellEditUseWholeCell = false;
            this.idBlocksList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3});
            this.idBlocksList.ContextMenu = this.idBlocksListContextMenu;
            this.idBlocksList.Cursor = System.Windows.Forms.Cursors.Default;
            this.idBlocksList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idBlocksList.FullRowSelect = true;
            this.idBlocksList.GridLines = true;
            this.idBlocksList.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.idBlocksList.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.idBlocksList.Location = new System.Drawing.Point(0, 0);
            this.idBlocksList.Name = "idBlocksList";
            this.idBlocksList.ShowGroups = false;
            this.idBlocksList.Size = new System.Drawing.Size(453, 600);
            this.idBlocksList.TabIndex = 0;
            this.idBlocksList.UseCompatibleStateImageBehavior = false;
            this.idBlocksList.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "id";
            this.olvColumn1.AspectToStringFormat = "0x{0:X8}";
            this.olvColumn1.Text = "ID";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "offset";
            this.olvColumn2.AspectToStringFormat = "0x{0:X8}";
            this.olvColumn2.Text = "Offset";
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "length";
            this.olvColumn3.AspectToStringFormat = "0x{0:X8}";
            this.olvColumn3.Text = "Size";
            // 
            // idBlocksListContextMenu
            // 
            this.idBlocksListContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.idBlocksExtractMenuItem});
            // 
            // idBlocksExtractMenuItem
            // 
            this.idBlocksExtractMenuItem.Index = 0;
            this.idBlocksExtractMenuItem.Text = "Extract...";
            this.idBlocksExtractMenuItem.Click += new System.EventHandler(this.idBlocksExtractMenuItem_Click);
            // 
            // IdBlocksFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.idBlocksList);
            this.Name = "IdBlocksFragment";
            this.Size = new System.Drawing.Size(453, 600);
            ((System.ComponentModel.ISupportInitialize)(this.idBlocksList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView idBlocksList;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private System.Windows.Forms.ContextMenu idBlocksListContextMenu;
        private System.Windows.Forms.MenuItem idBlocksExtractMenuItem;
    }
}
