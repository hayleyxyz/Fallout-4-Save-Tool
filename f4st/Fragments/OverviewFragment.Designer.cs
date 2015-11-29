namespace f4st.Fragments {
    partial class OverviewFragment {
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
            this.overviewListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // overviewListView
            // 
            this.overviewListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.overviewListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewListView.FullRowSelect = true;
            this.overviewListView.GridLines = true;
            this.overviewListView.Location = new System.Drawing.Point(0, 0);
            this.overviewListView.Margin = new System.Windows.Forms.Padding(0);
            this.overviewListView.Name = "overviewListView";
            this.overviewListView.Size = new System.Drawing.Size(453, 600);
            this.overviewListView.TabIndex = 0;
            this.overviewListView.UseCompatibleStateImageBehavior = false;
            this.overviewListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            // 
            // OverviewFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.overviewListView);
            this.Name = "OverviewFragment";
            this.Size = new System.Drawing.Size(453, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView overviewListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
