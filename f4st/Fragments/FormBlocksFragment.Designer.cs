namespace f4st.Fragments {
    partial class FormBlocksFragment {
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
            this.formBlocksList = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.formBlocksListContextMenu = new System.Windows.Forms.ContextMenu();
            this.extractMenuItem = new System.Windows.Forms.MenuItem();
            this.copyColumnMenuItem = new System.Windows.Forms.MenuItem();
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.formBlocksList)).BeginInit();
            this.SuspendLayout();
            // 
            // formBlocksList
            // 
            this.formBlocksList.AllColumns.Add(this.olvColumn1);
            this.formBlocksList.AllColumns.Add(this.olvColumn2);
            this.formBlocksList.AllColumns.Add(this.olvColumn5);
            this.formBlocksList.AllColumns.Add(this.olvColumn8);
            this.formBlocksList.AllColumns.Add(this.olvColumn6);
            this.formBlocksList.AllColumns.Add(this.olvColumn7);
            this.formBlocksList.AllColumns.Add(this.olvColumn3);
            this.formBlocksList.AllColumns.Add(this.olvColumn4);
            this.formBlocksList.CellEditUseWholeCell = false;
            this.formBlocksList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn5,
            this.olvColumn8,
            this.olvColumn6,
            this.olvColumn7,
            this.olvColumn3,
            this.olvColumn4});
            this.formBlocksList.ContextMenu = this.formBlocksListContextMenu;
            this.formBlocksList.Cursor = System.Windows.Forms.Cursors.Default;
            this.formBlocksList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formBlocksList.FullRowSelect = true;
            this.formBlocksList.GridLines = true;
            this.formBlocksList.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.formBlocksList.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.formBlocksList.Location = new System.Drawing.Point(0, 0);
            this.formBlocksList.Name = "formBlocksList";
            this.formBlocksList.ShowGroups = false;
            this.formBlocksList.Size = new System.Drawing.Size(453, 600);
            this.formBlocksList.TabIndex = 1;
            this.formBlocksList.UseCompatibleStateImageBehavior = false;
            this.formBlocksList.View = System.Windows.Forms.View.Details;
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
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "flags";
            this.olvColumn5.AspectToStringFormat = "0x{0:X8}";
            this.olvColumn5.Text = "Flags";
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "getTypeName";
            this.olvColumn6.AspectToStringFormat = "";
            this.olvColumn6.Text = "Type";
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "version";
            this.olvColumn7.AspectToStringFormat = "0x{0:X2}";
            this.olvColumn7.Text = "Version";
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "deflatedLength";
            this.olvColumn3.AspectToStringFormat = "0x{0:X4}";
            this.olvColumn3.Text = "Deflated Size";
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "inflatedLength";
            this.olvColumn4.AspectToStringFormat = "0x{0:X4}";
            this.olvColumn4.Text = "Inflated Size";
            // 
            // formBlocksListContextMenu
            // 
            this.formBlocksListContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.extractMenuItem,
            this.copyColumnMenuItem});
            // 
            // extractMenuItem
            // 
            this.extractMenuItem.Index = 0;
            this.extractMenuItem.Text = "Extract...";
            this.extractMenuItem.Click += new System.EventHandler(this.extractMenuItem_Click);
            // 
            // copyColumnMenuItem
            // 
            this.copyColumnMenuItem.Index = 1;
            this.copyColumnMenuItem.Text = "Copy column";
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "type";
            this.olvColumn8.AspectToStringFormat = "0x{0:X2}";
            this.olvColumn8.Text = "Type";
            // 
            // FormBlocksFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.formBlocksList);
            this.Name = "FormBlocksFragment";
            this.Size = new System.Drawing.Size(453, 600);
            ((System.ComponentModel.ISupportInitialize)(this.formBlocksList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView formBlocksList;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.ContextMenu formBlocksListContextMenu;
        private System.Windows.Forms.MenuItem extractMenuItem;
        private System.Windows.Forms.MenuItem copyColumnMenuItem;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
    }
}
