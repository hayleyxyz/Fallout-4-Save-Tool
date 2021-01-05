using System;
using System.Collections.Generic;
using System.IO;
using f4lib.Exceptions;

namespace f4lib.Save
{
    public class ApplicationInfo : SaveFragment {

        public byte formVersion;
        public string applicationVersion;
        public uint dataFilesLength;
        public List<string> dataFiles;

        public override void read(BinaryReader reader) {
            formVersion = reader.ReadByte();
            applicationVersion = readPrefixedString(reader);
            dataFilesLength = reader.ReadUInt32();
            dataFiles = new List<string>();

            var startOffset = reader.BaseStream.Position;
            
            var blockFilesCount = (int)reader.ReadByte();
            dataFiles.AddRange(readDataFiles(reader, blockFilesCount));

            while((reader.BaseStream.Position - startOffset) < dataFilesLength) {
                blockFilesCount = (int)reader.ReadUInt16();
                dataFiles.AddRange(readDataFiles(reader, blockFilesCount));
            }
        }

        protected IEnumerable<string> readDataFiles(BinaryReader reader, int count) {
            var dataFiles = new List<string>();

            for(var i = 0; i < count; i++) {
                var mf = readPrefixedString(reader);
                dataFiles.Add(mf);
            }

            return dataFiles;
        }

    }
}
