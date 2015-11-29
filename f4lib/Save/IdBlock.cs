using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace f4lib.Save
{
    public class IdBlock : SaveFragment {

        public long offset;

        public uint id;
        public uint length;
        public byte[] data;

        public override void read(BinaryReader reader) {
            offset = reader.BaseStream.Position;

            id = reader.ReadUInt32();
            length = reader.ReadUInt32();
            data = reader.ReadBytes((int)length);
        }

    }
}
