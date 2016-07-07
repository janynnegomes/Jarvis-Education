using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jarvis_for_Educators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripAbout_Click(object sender, EventArgs e)
        {
            new Sobre().ShowDialog();
        }
    }
}
