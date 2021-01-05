using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f4st {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            

            if(extractId(0x000000000001DA79) != 0x000000000041DA79) {
                throw new Exception();
            }

            if(extractId(0x000000000001DA67) != 0x000000000041DA67) {
                throw new Exception();
            }

            if(extractId(0x000000000001DA53) != 0x000000000041DA53) {
                throw new Exception();
            }

            if(extractId(0x000000000014244C) != 0x000000000054244C) {
                throw new Exception();
            }

            if(extractId(0x000000000009813C) != 0x000000000049813C) {
                throw new Exception();
            }

            if(extractId(0x000000000001DAB5) != 0x000000000041DAB5) {
                throw new Exception();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MainForm());
        }

        static uint extractId(uint a) {
            uint v4 = 0x800000;
            if((a >> 24) == 0) {
                v4 = 0x400000;
            }

            return a | v4;
        }
    }
}
