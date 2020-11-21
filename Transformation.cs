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
    public partial class Transformation : Form
    {
        private readonly Form1 _form;
        public Transformation(Form1 form)
        {
            InitializeComponent();
            _form = form;
        }
    }
}
