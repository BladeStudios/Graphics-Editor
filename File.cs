using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Windows.Forms;

namespace Graphics_Editor
{
    class File
    {
        private readonly Form1 _form;
        public File(Form1 form)
        {
            _form = form;
        }

        public void New()
        {
            _form.pictureBox = null;
        }
    }
}
