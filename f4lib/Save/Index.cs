using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace f4lib.Save
{
    public class Index : SaveFragment {

        public uint offset1;
        public uint offset2;
        public uint offset3;
        public uint offset4;
        public uint offset5;
        public uint offset6;

        public uint blockCount1;
        public uint blockCount2;
        public uint blockCount3;
        public uint blockCount4;

        public override void read(BinaryReader reader) {
            offset1 = reader.ReadUInt32();
            offset2 = reader.ReadUInt32();
            offset3 = reader.ReadUInt32();
            offset4 = reader.ReadUInt32();
            offset5 = reader.ReadUInt32();
            offset6 = reader.ReadUInt32();

            blockCount1 = reader.ReadUInt32();
            blockCount2 = reader.ReadUInt32();
            blockCount3 = reader.ReadUInt32();
            blockCount4 = reader.ReadUInt32();
        }

    }
}
