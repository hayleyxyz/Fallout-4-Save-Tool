namespace f4st.Forms {
    partial class MainForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenuItem = new System.Windows.Forms.MenuItem();
            this.openMenuItem = new System.Windows.Forms.MenuItem();
            this.compareMenuItem = new System.Windows.Forms.MenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.overviewTabPage = new System.Windows.Forms.TabPage();
            this.overviewFragment = new f4st.Fragments.OverviewFragment();
            this.idBlocksTabPage = new System.Windows.Forms.TabPage();
            this.idBlocksFragment = new f4st.Fragments.IdBlocksFragment();
            this.formBlocksTabPage = new System.Windows.Forms.TabPage();
            this.formBlocksFragment = new f4st.Fragments.FormBlocksFragment();
            this.saveScreenshotMenuItem = new System.Windows.Forms.MenuItem();
            this.tabControl.SuspendLayout();
            this.overviewTabPage.SuspendLayout();
            this.idBlocksTabPage.SuspendLayout();
            this.formBlocksTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem});
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Index = 0;
            this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.openMenuItem,
            this.compareMenuItem,
            this.saveScreenshotMenuItem});
            this.fileMenuItem.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Index = 0;
            this.openMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // compareMenuItem
            // 
            this.compareMenuItem.Index = 1;
            this.compareMenuItem.Text = "Compare Save";
            this.compareMenuItem.Click += new System.EventHandler(this.compareMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.overviewTabPage);
            this.tabControl.Controls.Add(this.idBlocksTabPage);
            this.tabControl.Controls.Add(this.formBlocksTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(564, 570);
            this.tabControl.TabIndex = 0;
            // 
            // overviewTabPage
            // 
            this.overviewTabPage.BackColor = System.Drawing.Color.Transparent;
            this.overviewTabPage.Controls.Add(this.overviewFragment);
            this.overviewTabPage.Location = new System.Drawing.Point(4, 22);
            this.overviewTabPage.Name = "overviewTabPage";
            this.overviewTabPage.Size = new System.Drawing.Size(556, 544);
            this.overviewTabPage.TabIndex = 0;
            this.overviewTabPage.Text = "Overview";
            // 
            // overviewFragment
            // 
            this.overviewFragment.BackColor = System.Drawing.Color.Transparent;
            this.overviewFragment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewFragment.Location = new System.Drawing.Point(0, 0);
            this.overviewFragment.Name = "overviewFragment";
            this.overviewFragment.Size = new System.Drawing.Size(556, 544);
            this.overviewFragment.TabIndex = 0;
            // 
            // idBlocksTabPage
            // 
            this.idBlocksTabPage.Controls.Add(this.idBlocksFragment);
            this.idBlocksTabPage.Location = new System.Drawing.Point(4, 22);
            this.idBlocksTabPage.Name = "idBlocksTabPage";
            this.idBlocksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.idBlocksTabPage.Size = new System.Drawing.Size(556, 544);
            this.idBlocksTabPage.TabIndex = 1;
            this.idBlocksTabPage.Text = global::f4st.strings.IdBlocks;
            this.idBlocksTabPage.UseVisualStyleBackColor = true;
            // 
            // idBlocksFragment
            // 
            this.idBlocksFragment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idBlocksFragment.Location = new System.Drawing.Point(3, 3);
            this.idBlocksFragment.Name = "idBlocksFragment";
            this.idBlocksFragment.Size = new System.Drawing.Size(550, 538);
            this.idBlocksFragment.TabIndex = 0;
            // 
            // formBlocksTabPage
            // 
            this.formBlocksTabPage.Controls.Add(this.formBlocksFragment);
            this.formBlocksTabPage.Location = new System.Drawing.Point(4, 22);
            this.formBlocksTabPage.Name = "formBlocksTabPage";
            this.formBlocksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.formBlocksTabPage.Size = new System.Drawing.Size(556, 544);
            this.formBlocksTabPage.TabIndex = 2;
            this.formBlocksTabPage.Text = global::f4st.strings.FormBlocks;
            this.formBlocksTabPage.UseVisualStyleBackColor = true;
            // 
            // formBlocksFragment
            // 
            this.formBlocksFragment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formBlocksFragment.Location = new System.Drawing.Point(3, 3);
            this.formBlocksFragment.Name = "formBlocksFragment";
            this.formBlocksFragment.Size = new System.Drawing.Size(550, 538);
            this.formBlocksFragment.TabIndex = 0;
            // 
            // saveScreenshotMenuItem
            // 
            this.saveScreenshotMenuItem.Enabled = false;
            this.saveScreenshotMenuItem.Index = 2;
            this.saveScreenshotMenuItem.Text = "Save Screenshot";
            this.saveScreenshotMenuItem.Click += new System.EventHandler(this.saveScreenshotMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 570);
            this.Controls.Add(this.tabControl);
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.overviewTabPage.ResumeLayout(false);
            this.idBlocksTabPage.ResumeLayout(false);
            this.formBlocksTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem fileMenuItem;
        private System.Windows.Forms.MenuItem openMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage overviewTabPage;
        private System.Windows.Forms.TabPage idBlocksTabPage;
        private Fragments.OverviewFragment overviewFragment;
        private Fragments.IdBlocksFragment idBlocksFragment;
        private System.Windows.Forms.TabPage formBlocksTabPage;
        private Fragments.FormBlocksFragment formBlocksFragment;
        private System.Windows.Forms.MenuItem compareMenuItem;
        private System.Windows.Forms.MenuItem saveScreenshotMenuItem;
    }
}