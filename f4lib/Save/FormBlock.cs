using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Security.Cryptography;

namespace f4lib.Save
{
    public class FormBlock : SaveFragment, IEquatable<FormBlock> {

        public enum LengthType : uint {
            UInt8 = 0,
            UInt16 = 1
        }

        public long offset;

        public uint id;
        public uint rawId;
        public uint flags;
        public byte type;
        public byte version;
        public ushort deflatedLength;
        public ushort inflatedLength;
        public byte[] data;

        public static readonly byte[] typeLookup = new byte[] {
            0x40, 0x41, 0x42, 0x44, 0x45, 0x46, 0x3F, 0x4F, 0x50, 0x2D,
            0x1B, 0x1C, 0x1D, 0x1E, 0x1F, 0x20, 0x21, 0x22, 0x23, 0x24,
            0x26, 0x2A, 0x2B, 0x2C, 0x2F, 0x30, 0x31, 0x32, 0x6A, 0x0D,
            0x0E, 0x52, 0x4C, 0x7A, 0x15, 0x75, 0x7E, 0x6B, 0x7D, 0x49,
            0x48, 0x47, 0x5E, 0x2E, 0x38, 0x55, 0x43, 0x18, 0x37, 0x93
        };

        public static readonly string[] typeNames = new string[] {
            "NONE", "TES4", "GRUP", "GMST", "KYWD", "LCRT", "AACT", "TRNS",
            "CMPO", "TXST", "MICN", "GLOB", "DMGT", "CLAS", "FACT", "HDPT",
            "EYES", "RACE", "SOUN", "ASPC", "SKIL", "MGEF", "SCPT", "LTEX",
            "ENCH", "SPEL", "SCRL", "ACTI", "TACT", "ARMO", "BOOK", "CONT",
            "DOOR", "INGR", "LIGH", "MISC", "STAT", "SCOL", "MSTT", "GRAS",
            "TREE", "FLOR", "FURN", "WEAP", "AMMO", "NPC_", "LVLN", "KEYM",
            "ALCH", "IDLM", "NOTE", "PROJ", "HAZD", "BNDS", "SLGM", "TERM",
            "LVLI", "WTHR", "CLMT", "SPGD", "RFCT", "REGN", "NAVI", "CELL",
            "REFR", "ACHR", "PMIS", "PARW", "PGRE", "PBEA", "PFLA", "PCON",
            "PBAR", "PHZD", "WRLD", "LAND", "NAVM", "TLOD", "DIAL", "INFO",
            "QUST", "IDLE", "PACK", "CSTY", "LSCR", "LVSP", "ANIO", "WATR",
            "EFSH", "TOFT", "EXPL", "DEBR", "IMGS", "IMAD", "FLST", "PERK",
            "BPTD", "ADDN", "AVIF", "CAMS", "CPTH", "VTYP", "MATT", "IPCT",
            "IPDS", "ARMA", "ECZN", "LCTN", "MESG", "RGDL", "DOBJ", "DFOB",
            "LGTM", "MUSC", "FSTP", "FSTS", "SMBN", "SMQN", "SMEN", "DLBR",
            "MUST", "DLVW", "WOOP", "SHOU", "EQUP", "RELA", "SCEN", "ASTP",
            "OTFT", "ARTO", "MATO", "MOVT", "SNDR", "DUAL", "SNCT", "SOPM",
            "COLL", "CLFM", "REVB", "PKIN", "RFGP", "AMDL", "LAYR", "COBJ",
            "OMOD", "MSWP", "ZOOM", "INNR", "KSSM", "AECH", "SCCO", "AORU",
            "SCSN", "STAG", "NOCM", "LENS", "LSPR", "GDRY", "OVIS"
        };

        public override void read(BinaryReader reader) {
            offset = reader.BaseStream.Position;

            var idBytes = reader.ReadBytes(3);
            id = extractId(idBytes);
            rawId = (uint)((idBytes[0] << 16) | (idBytes[1] << 8) | idBytes[2]);

            flags = reader.ReadUInt32();
            type = reader.ReadByte();
            version = reader.ReadByte();



            var lengthType = (LengthType)(type >> 6);

            switch (lengthType) {
                case LengthType.UInt8:
                    deflatedLength = reader.ReadByte();
                    inflatedLength = reader.ReadByte();
                    break;

                case LengthType.UInt16:
                    deflatedLength = reader.ReadUInt16();
                    inflatedLength = reader.ReadUInt16();
                    break;
            }

            data = reader.ReadBytes((int)deflatedLength);
        }

        protected uint extractId(byte[] data) {
            uint a, b;

            a = (uint)((data[0] << 16) | (data[1] << 8) | data[2]);
            uint v4 = 0x800000;
            if(data[0] == 0) {
                v4 = 0x400000;
            }

            return a | v4;
        }

        public string getTypeName() {
            byte typeNameIndex = typeLookup[(type & 0x3F)];

            return typeNames[typeNameIndex];
        }

        public bool isCompressed() {
            return (inflatedLength != 0);
        }

        public byte[] inflateData() {
            using (var stream = new MemoryStream(data)) {
                // Skip the first 2 bytes
                stream.Seek(2, SeekOrigin.Begin);

                using (var deflate = new DeflateStream(stream, CompressionMode.Decompress, true)) {
                    var inflated = new byte[inflatedLength];
                    deflate.Read(inflated, 0, inflated.Length);

                    return inflated;
                }
            }
        }

        public bool Equals(FormBlock other) {
            if (other.id == this.id && other.type == this.type) {
                var sha = new SHA1Cng();

                var hashA = sha.ComputeHash(this.data);
                var hashB = sha.ComputeHash(other.data);

                return Utils.Buffer.compare(hashA, hashB);
            }

            return false;
        }

    }
}
