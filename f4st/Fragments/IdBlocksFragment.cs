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

namespace f4st.Fragments {

    public partial class IdBlocksFragment : UserControl, ControlFragment {

        public IdBlocksFragment() {
            InitializeComponent();
        }

        public void loadSave(SaveFile saveFile) {
            idBlocksList.SetObjects(saveFile.idBlocks);
            idBlocksList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void idBlocksExtractMenuItem_Click(object sender, EventArgs e) {
            var items = idBlocksList.SelectedItems;

            if(items.Count > 0) {
                var fbd = new FolderBrowserDialog();

                if(fbd.ShowDialog() == DialogResult.OK) {
                    foreach(OLVListItem item in items) {
                        var idBlock = (IdBlock)item.RowObject;

                        var path = String.Format("{0}\\{1:X8}.bin", fbd.SelectedPath, idBlock.id);

                        File.WriteAllBytes(path, idBlock.data);
                    }

                    MessageBox.Show(String.Format("{0} block(s) extracted successfully", items.Count), "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }

}
