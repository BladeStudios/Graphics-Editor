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
    public partial class Form1 : Form
    {
        File file;
        public Form1()
        {
            InitializeComponent();
            file = new File(this);
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            file.New();
        }

        private void menuFileNewWindow_Click(object sender, EventArgs e)
        {
            file.NewWindow();
        }
    }
}
