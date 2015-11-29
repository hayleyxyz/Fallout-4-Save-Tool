using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace f4lib.Save
{
    public class ApplicationInfo : SaveFragment {

        public byte formVersion;
        public string applicationVersion;
        public uint dataFilesLength;
        public byte dataFilesCount;
        public List<string> dataFiles;

        public override void read(BinaryReader reader) {
            formVersion = reader.ReadByte();
            applicationVersion = readPrefixedString(reader);
            dataFilesLength = reader.ReadUInt32();
            dataFilesCount = reader.ReadByte();

            dataFiles = new List<string>(dataFilesCount);
            for(var i = 0; i < dataFilesCount; i++) {
                var mf = readPrefixedString(reader);
                dataFiles.Add(mf);
            }
        }

    }
}
