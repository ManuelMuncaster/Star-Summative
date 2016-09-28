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
using System.Media;
namespace Star_Summative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
         
            InitializeComponent();
        }

        private void drawOrion_Click(object sender, EventArgs e)
        {

            Graphics formGraphics = this.CreateGraphics();
            Graphics fg = this.CreateGraphics();

            labelTitle.Visible = false;
            drawOrion.Visible = false;
            labelName.Visible = false;

            //test
          




        }
    }
}
