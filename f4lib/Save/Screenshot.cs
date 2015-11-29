using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace f4lib.Save
{
    public class Screenshot : SaveFragment {

        public uint width;
        public uint height;
        public byte[] pixelData;

        public Screenshot(uint width, uint height) {
            this.width = width;
            this.height = height;
        }

        public override void read(BinaryReader reader) {
            var pixelDataLength = (width * height * 4);
            pixelData = reader.ReadBytes((int)pixelDataLength);
        }

    }
}
