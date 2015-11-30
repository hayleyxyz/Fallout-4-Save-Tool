using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using f4st.Contracts;
using f4lib.Save;
using BrightIdeasSoftware;
using System.Diagnostics;

namespace f4st.Fragments {
    public partial class FormBlocksFragment : UserControl, ControlFragment {

        public FormBlocksFragment() {
            InitializeComponent();

            addCopyColumnMenuItems();
        }

        public void loadSave(SaveFile saveFile) {
            formBlocksList.SetObjects(saveFile.formBlocks.Values);
            
            formBlocksList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void extractMenuItem_Click(object sender, EventArgs e) {
            var items = formBlocksList.SelectedItems;

            if (items.Count > 0) {
                var fbd = new FolderBrowserDialog();

                if (fbd.ShowDialog() == DialogResult.OK) {
                    foreach (OLVListItem item in items) {
                        var formBlock = (FormBlock)item.RowObject;

                        var path = String.Format("{0}\\{2}_{1:X8}.bin", fbd.SelectedPath, formBlock.id, formBlock.getTypeName());

                        if (formBlock.isCompressed()) {
                            File.WriteAllBytes(path, formBlock.inflateData());
                        }
                        else {
                            File.WriteAllBytes(path, formBlock.data);
                        }
                    }

                    MessageBox.Show(String.Format("{0} block(s) extracted successfully", items.Count), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void copyColumnMenuItem_Click(object sender, EventArgs e) {
            var selectedItems = formBlocksList.SelectedItems;

            if (selectedItems.Count > 0) {
                var menuItem = (MenuItem)sender;
                var columnIndex = (int)menuItem.Tag;

                var sb = new StringBuilder();

                foreach(OLVListItem item in selectedItems) {
                    var subItems = item.SubItems;
                    sb.AppendLine(subItems[columnIndex].Text);
                }

                var result = sb.ToString().TrimEnd(Environment.NewLine.ToCharArray());
                Clipboard.SetText(result);
            }
        }

        protected void addCopyColumnMenuItems() {
            foreach(OLVColumn column in formBlocksList.Columns) {
                var menuItem = new MenuItem() {
                    Text = column.Text,
                    Tag = column.Index
                };

                menuItem.Click += new EventHandler(copyColumnMenuItem_Click);

                copyColumnMenuItem.MenuItems.Add(menuItem);
            }
        }
    }
}
