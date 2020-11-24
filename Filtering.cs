using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Editor
{
    public partial class Filtering : Form
    {
        private readonly Form1 _form;
        public Bitmap img;

        public Filtering(Form1 form)
        {
            InitializeComponent();
            _form = form;
            img = new Bitmap(_form.getImage());
        }
    }
}
