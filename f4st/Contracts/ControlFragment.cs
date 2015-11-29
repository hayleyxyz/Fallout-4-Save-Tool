using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using f4lib.Save;

namespace f4st.Contracts {

    public interface ControlFragment {

        void loadSave(SaveFile saveFile);

    }

}
