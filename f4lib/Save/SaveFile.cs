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
        public Dictionary<uint, IdBlock> idBlocks;
        public Dictionary<uint, FormBlock> formBlocks;

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

            idBlocks = new Dictionary<uint, IdBlock>();

            reader.BaseStream.Seek(index.offset3, SeekOrigin.Begin);

            for(var i = 0; i < index.blockCount1; i++) {
                var idBlock = new IdBlock();
                idBlock.read(reader);
                idBlocks.Add(idBlock.id, idBlock);
            }

            reader.BaseStream.Seek(index.offset4, SeekOrigin.Begin);

            for (var i = 0; i < index.blockCount2; i++) {
                var idBlock = new IdBlock();
                idBlock.read(reader);
                idBlocks.Add(idBlock.id, idBlock);
            }

            reader.BaseStream.Seek(index.offset6, SeekOrigin.Begin);

            for (var i = 0; i < index.blockCount3; i++) {
                var idBlock = new IdBlock();
                idBlock.read(reader);
                idBlocks.Add(idBlock.id, idBlock);
            }

            formBlocks = new Dictionary<uint, FormBlock>();

            reader.BaseStream.Seek(index.offset5, SeekOrigin.Begin);

            for(var i = 0; i < index.blockCount4; i++) {
                var formBlock = new FormBlock();
                formBlock.read(reader);
                formBlocks.Add(formBlock.rawId, formBlock);
            }
        }
    }
}
