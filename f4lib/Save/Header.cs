using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using f4lib.Save;

namespace f4lib.Save
{
    public class Header : SaveFragment {

        public enum PlayerSex : ushort {
            Male = 0,
            Female = 1
        }

        const int SIGNATURE_LENGTH = 0xC;

        public byte[] signature;
        public uint headerLength;
        public uint saveVersion;
        public uint saveNumber;
        public string playerName;
        public uint playerLevel;
        public string locationName;
        public string playDurationString;
        public string playerRaceString;
        public PlayerSex playerSex;
        public float playerExp;
        public float playerRequiredExp;
        public DateTime saveDateTime;
        public uint screenshotWidth;
        public uint screenshotHeight;

        public override void read(BinaryReader reader) {
            signature = reader.ReadBytes(SIGNATURE_LENGTH);
            headerLength = reader.ReadUInt32();
            saveVersion = reader.ReadUInt32();
            saveNumber = reader.ReadUInt32();
            playerName = readPrefixedString(reader);
            playerLevel = reader.ReadUInt32();
            locationName = readPrefixedString(reader);
            playDurationString = readPrefixedString(reader);
            playerRaceString = readPrefixedString(reader);
            playerSex = (PlayerSex)reader.ReadUInt16();
            playerExp = reader.ReadSingle();
            playerRequiredExp = reader.ReadSingle();
            saveDateTime = DateTime.FromFileTime((long)reader.ReadUInt64());
            screenshotWidth = reader.ReadUInt32();
            screenshotHeight = reader.ReadUInt32();
        }

        public string getSignatureString() {
            return Encoding.ASCII.GetString(signature);
        }
    }
}
