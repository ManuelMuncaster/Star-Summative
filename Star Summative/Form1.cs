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

            Pen whitePen = new Pen(Color.White, 10);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            Thread.Sleep(1500);
            Refresh();

            formGraphics.FillEllipse(whiteBrush, 14, 52, 10, 10);
            Thread.Sleep(1000);
            formGraphics.FillEllipse(whiteBrush, 43, 55, 10, 10);
            Thread.Sleep(1000);
            formGraphics.FillEllipse(whiteBrush, 39, 122, 10, 10);
            Thread.Sleep(1000);
            formGraphics.FillEllipse(whiteBrush, 25, 129, 10, 10);
            Thread.Sleep(1000);
            formGraphics.FillEllipse(whiteBrush, 86, 174, 10, 10);
            Thread.Sleep(1000);
            formGraphics.FillEllipse(whiteBrush, 124, 187, 10, 10);
            Thread.Sleep(1000);
            formGraphics.FillEllipse(whiteBrush, 169, 129, 10, 10);
            Thread.Sleep(1000);
            formGraphics.FillEllipse(whiteBrush, 226, 152, 10, 10);
            Thread.Sleep(1000);
            









        }
    }
}
