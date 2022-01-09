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

        protected SaveFile saveFile;

        public MainForm() {
            InitializeComponent();
        }

        private void openMenuItem_Click(object sender, EventArgs e) {
            var ofd = new OpenFileDialog() {
                Filter = "Fallout 4 Save Files (*.fos)|*.fos|All Files|*"
            };

            if(ofd.ShowDialog() == DialogResult.OK) {
                using (var stream = File.OpenRead(ofd.FileName)) {
                    saveFile = new SaveFile(stream);

                    saveFile.read();

                    overviewFragment.loadSave(saveFile);
                    idBlocksFragment.loadSave(saveFile);
                    idBlocksTabPage.Text = String.Format("{0} ({1:n0})", strings.IdBlocks, saveFile.idBlocks.Count);

                    formBlocksFragment.loadSave(saveFile);
                    formBlocksTabPage.Text = String.Format("{0} ({1:n0})", strings.FormBlocks, saveFile.formBlocks.Count);
                }

                saveScreenshotMenuItem.Enabled = true;
            }
        }

        private void compareMenuItem_Click(object sender, EventArgs e) {
            var ofd = new OpenFileDialog() {
                Filter = "Fallout 4 Save Files (*.fos)|*.fos|All Files|*"
            };

            if (ofd.ShowDialog() != DialogResult.OK) {
                return;
            }

            var fbd = new FolderBrowserDialog();

            if(fbd.ShowDialog() != DialogResult.OK) {
                return;
            }

            var targetDirA = String.Format("{0}\\A", fbd.SelectedPath);
            var targetDirB = String.Format("{0}\\B", fbd.SelectedPath);

            if(!Directory.Exists(targetDirA)) {
                Directory.CreateDirectory(targetDirA);
            }

            if (!Directory.Exists(targetDirB)) {
                Directory.CreateDirectory(targetDirB);
            }

            using (var stream = File.OpenRead(ofd.FileName)) {
                var compareSaveFile = new SaveFile(stream);

                compareSaveFile.read();

                string targetFile = null;

                foreach (var block in saveFile.idBlocks.Values) {
                    if(!compareSaveFile.idBlocks.ContainsKey(block.id)) {
                        targetFile = String.Format("{0}\\{1:X8}.bin", targetDirA, block.id);
                        File.WriteAllBytes(targetFile, block.data);
                    }
                    else {
                        var otherBlock = compareSaveFile.idBlocks[block.id];

                        if (!block.Equals(otherBlock)) {
                            targetFile = String.Format("{0}\\{1:X8}.bin", targetDirA, block.id);
                            File.WriteAllBytes(targetFile, block.data);

                            targetFile = String.Format("{0}\\{1:X8}.bin", targetDirB, block.id);
                            File.WriteAllBytes(targetFile, otherBlock.data);
                        }
                    }
                }

                foreach(var block in saveFile.formBlocks.Values) {
                    if(!compareSaveFile.formBlocks.ContainsKey(block.id)) {
                        targetFile = String.Format("{0}\\{2}_{1:X8}.bin", targetDirA, block.id, block.getTypeName());
                        File.WriteAllBytes(targetFile, block.inflateData());
                    }
                    else {
                        var otherBlock = compareSaveFile.formBlocks[block.id];

                        if (!block.Equals(otherBlock)) {
                            targetFile = String.Format("{0}\\{2}_{1:X8}.bin", targetDirA, block.id, block.getTypeName());
                            File.WriteAllBytes(targetFile, block.inflateData());

                            targetFile = String.Format("{0}\\{2}_{1:X8}.bin", targetDirB, block.id, block.getTypeName());
                            File.WriteAllBytes(targetFile, otherBlock.inflateData());
                        }
                    }
                }
            }
        }

        private void saveScreenshotMenuItem_Click(object sender, EventArgs e) {
            var sfd = new SaveFileDialog();
            
            if(sfd.ShowDialog() != DialogResult.OK) {
                return;
            }

            using(var stream = sfd.OpenFile()) {
                var data = saveFile.screenshot.pixelData;
                unsafe {
                    fixed(byte* p = data) {
                        var i = new System.Drawing.Bitmap((int)saveFile.screenshot.width, (int)saveFile.screenshot.height); //, 4, System.Drawing.Imaging.PixelFormat.Format32bppPArgb, new IntPtr(p));

                        for(var y = 0; y < saveFile.screenshot.height; y++) {
                            for(var x = 0; x < saveFile.screenshot.width; x++) {

                                i.SetPixel(x, y, Color.FromArgb(data[(((y * saveFile.screenshot.width) + x) * 4) + 0], data[(((y * saveFile.screenshot.width) + x) * 4) + 1], data[(((y * saveFile.screenshot.width) + x) * 4) + 2]));
                            }
                        }
                        +
                        using(var ms = new MemoryStream()) {
                            Bitmap bmp = new Bitmap(i);
                            bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                            var d = ms.ToArray();
                        }

                        
                        //i.Save(stream, System.Drawing.Imaging.ImageCodecInfo)
                        
                    }
                }

                
                

                
            }
        }
    }
}
