using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Key
{
    public partial class Key : Form
    {
        public Key()
        {
            InitializeComponent();
        }

        private void Key_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Key_MouseUp(object sender, MouseEventArgs e)
        {


            this.BackColor = Color.White;
        }

        private void Key_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
    }
}
