using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using f4lib.Utils;

namespace f4lib.Save
{
    public class IdBlock : SaveFragment, IEquatable<IdBlock> {

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

        public bool Equals(IdBlock other) {
            if(other.id == this.id) {
                var sha = new SHA1Cng();

                var hashA = sha.ComputeHash(this.data);
                var hashB = sha.ComputeHash(other.data);

                return Utils.Buffer.compare(hashA, hashB);
            }

            return false;
        }
    }
}
