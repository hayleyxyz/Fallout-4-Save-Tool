using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using f4lib.Save;
using f4st.Contracts;
using f4st.Fragments;

namespace f4st.Forms {
    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
        }

        private void openMenuItem_Click(object sender, EventArgs e) {
            var ofd = new OpenFileDialog() {
                Filter = "Fallout 4 Save Files (*.fos)|*.fos|All Files|*"
            };

            if(ofd.ShowDialog() == DialogResult.OK) {
                using (var stream = File.OpenRead(ofd.FileName)) {
                    var save = new SaveFile(stream);

                    save.read();

                    overviewFragment.loadSave(save);
                    idBlocksFragment.loadSave(save);
                    formBlocksFragment.loadSave(save);
                }
            }
        }
    }
}
