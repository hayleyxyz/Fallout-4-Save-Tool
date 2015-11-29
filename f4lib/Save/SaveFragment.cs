using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace f4lib.Save
{
    public abstract class SaveFragment {

        public abstract void read(BinaryReader reader);

        protected string readPrefixedString(BinaryReader reader) {
            var length = reader.ReadUInt16();
            var data = reader.ReadBytes(length);
            return Encoding.UTF8.GetString(data);
        }

    }
}
