using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace f4lib.Save
{
    public class SaveFile : SaveFragment {

        public Stream stream;

        public Header header;
        public Screenshot screenshot;
        public ApplicationInfo applicationInfo;
        public Index index;
        public List<IdBlock> idBlocks;
        public List<FormBlock> formBlocks;

        public SaveFile(Stream stream) {
            this.stream = stream;
        }

        public void read() {
            using(var reader = new BinaryReader(stream, Encoding.UTF8, true)) {
                read(reader);
            }
        }

        public override void read(BinaryReader reader) {
            reader.BaseStream.Seek(0, SeekOrigin.Begin);

            header = new Header();
            header.read(reader);

            screenshot = new Screenshot(header.screenshotWidth, header.screenshotHeight);
            screenshot.read(reader);

            applicationInfo = new ApplicationInfo();
            applicationInfo.read(reader);

            index = new Index();
            index.read(reader);

            idBlocks = new List<IdBlock>();

            reader.BaseStream.Seek(index.offset3, SeekOrigin.Begin);

            for(var i = 0; i < index.blockCount1; i++) {
                var idBlock = new IdBlock();
                idBlock.read(reader);
                idBlocks.Add(idBlock);
            }

            reader.BaseStream.Seek(index.offset4, SeekOrigin.Begin);

            for (var i = 0; i < index.blockCount2; i++) {
                var idBlock = new IdBlock();
                idBlock.read(reader);
                idBlocks.Add(idBlock);
            }

            reader.BaseStream.Seek(index.offset6, SeekOrigin.Begin);

            for (var i = 0; i < index.blockCount3; i++) {
                var idBlock = new IdBlock();
                idBlock.read(reader);
                idBlocks.Add(idBlock);
            }

            formBlocks = new List<FormBlock>();

            reader.BaseStream.Seek(index.offset5, SeekOrigin.Begin);

            while (true) {
                if (stream.Position >= index.offset6 || stream.Position >= stream.Length) {
                    break;
                }

                var formBlock = new FormBlock();
                formBlock.read(reader);
                formBlocks.Add(formBlock);
            }
        }
    }
}
