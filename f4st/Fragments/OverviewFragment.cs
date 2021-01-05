using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using f4st.Contracts;
using f4lib.Save;

namespace f4st.Fragments {

    public partial class OverviewFragment : UserControl, ControlFragment {

        public event EventHandler saveLoaded;

        public OverviewFragment() {
            InitializeComponent();
        }

        public void loadSave(SaveFile saveFile) {
            addOverviewItem("Signature", saveFile.header.getSignatureString());
            addOverviewItem("Save version", saveFile.header.saveVersion);
            addOverviewItem("Save number", saveFile.header.saveNumber.ToString());
            addOverviewItem("Player name", saveFile.header.playerName);
            addOverviewItem("Player level", saveFile.header.playerLevel.ToString());
            addOverviewItem("Location", saveFile.header.locationName);
            addOverviewItem("Play duration", saveFile.header.playDurationString);
            addOverviewItem("Player race", saveFile.header.playerRaceString);
            addOverviewItem("Player sex", saveFile.header.playerSex.ToString());
            addOverviewItem("Player XP", saveFile.header.playerExp);
            addOverviewItem("Player required XP", saveFile.header.playerRequiredExp);
            addOverviewItem("Save date/time", saveFile.header.saveDateTime.ToString());
            addOverviewItem("Screenshot width", saveFile.header.screenshotWidth.ToString());
            addOverviewItem("Screenshot height", saveFile.header.screenshotHeight.ToString());

            addOverviewItem("Form version", saveFile.applicationInfo.formVersion);
            addOverviewItem("Application version", saveFile.applicationInfo.applicationVersion);
            addOverviewItem("Data files length", saveFile.applicationInfo.dataFilesLength);
            addOverviewItem("Data files count", saveFile.applicationInfo.dataFiles.Count);

            for(var i = 0; i < saveFile.applicationInfo.dataFiles.Count; i++) {
                var name = String.Format("Data file #{0}", i);
                addOverviewItem(name, saveFile.applicationInfo.dataFiles[i]);
            }

            addOverviewItem("Offset 1", saveFile.index.offset1);
            addOverviewItem("Offset 2", saveFile.index.offset2);
            addOverviewItem("Offset 3", saveFile.index.offset3);
            addOverviewItem("Offset 4", saveFile.index.offset4);
            addOverviewItem("Offset 5", saveFile.index.offset5);
            addOverviewItem("Offset 6", saveFile.index.offset6);

            addOverviewItem("Block count 1", saveFile.index.blockCount1);
            addOverviewItem("Block count 2", saveFile.index.blockCount2);
            addOverviewItem("Block count 3", saveFile.index.blockCount3);
            addOverviewItem("Block count 4", saveFile.index.blockCount4);

            overviewListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        protected void addOverviewItem(string name, float value) {
            var formatted = String.Format("{0:f}", value);
            addOverviewItem(name, formatted);
        }

        protected void addOverviewItem(string name, uint value) {
            var formatted = String.Format("0x{0:X8}", value);
            addOverviewItem(name, formatted);
        }

        protected void addOverviewItem(string name, string value) {
            var item = new ListViewItem(name);
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, value));

            overviewListView.Items.Add(item);
        }
    }

}
