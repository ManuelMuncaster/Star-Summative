/* Created by: Manuel Muncaster
 * Date: October 1, 2016
 * Purpose: Greeting Card Summative
 */
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
            //Setting up Graphics
            Graphics formGraphics = this.CreateGraphics();
            Graphics fg = this.CreateGraphics();
            
            //Clearing the title screen to draw the stars
            labelTitle.Visible = false;
            drawOrion.Visible = false;
            labelName.Visible = false;
            this.BackColor = Color.Black;

            //Setting up pens and brush
            Pen whitePen = new Pen(Color.White, 2);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            
            //All of the sounds played when the stars are drawn
            SoundPlayer player0 = new SoundPlayer(Properties.Resources.itsme);
            SoundPlayer player11 = new SoundPlayer(Properties.Resources.up);
            SoundPlayer player12 = new SoundPlayer(Properties.Resources.bowserfire);
            SoundPlayer player13 = new SoundPlayer(Properties.Resources.breakblock);
            SoundPlayer player14 = new SoundPlayer(Properties.Resources.bump);
            SoundPlayer player15 = new SoundPlayer(Properties.Resources.coin);
            SoundPlayer player16 = new SoundPlayer(Properties.Resources.fireball);
            SoundPlayer player17 = new SoundPlayer(Properties.Resources.fireworks);
            SoundPlayer player18 = new SoundPlayer(Properties.Resources.jump);
            SoundPlayer player19 = new SoundPlayer(Properties.Resources.kick);
            SoundPlayer player20 = new SoundPlayer(Properties.Resources.pipe);
            SoundPlayer player21 = new SoundPlayer(Properties.Resources.powerup);
            SoundPlayer player22 = new SoundPlayer(Properties.Resources.powerupappears);
            SoundPlayer player23 = new SoundPlayer(Properties.Resources.stomp);

            //Placing all of the stars onto the screen
            Thread.Sleep(1500);
            Refresh();
            player0.Play();
            Thread.Sleep(2000);
            player11.Play();
            formGraphics.FillEllipse(whiteBrush, 69, 17, 10, 10);
            Thread.Sleep(1000);
            player12.Play();
            formGraphics.FillEllipse(whiteBrush, 90, 13, 10, 10);
            Thread.Sleep(1000);
            player13.Play();
            formGraphics.FillEllipse(whiteBrush, 73, 55, 10, 10);
            Thread.Sleep(1000);
            player14.Play();
            formGraphics.FillEllipse(whiteBrush, 82, 51, 10, 10);
            Thread.Sleep(1000);
            player15.Play();
            formGraphics.FillEllipse(whiteBrush, 91, 90, 10, 10);
            Thread.Sleep(1000);
            player16.Play();
            formGraphics.FillEllipse(whiteBrush, 105, 108, 10, 10);
            Thread.Sleep(1000);
            player17.Play();
            formGraphics.FillEllipse(whiteBrush, 143, 90, 10, 10);
            Thread.Sleep(1000);
            player18.Play();
            formGraphics.FillEllipse(whiteBrush, 161, 117, 10, 10);
            Thread.Sleep(1000);
            player19.Play();
            formGraphics.FillEllipse(whiteBrush, 131, 181, 10, 10);
            Thread.Sleep(1000);
            player20.Play();
            formGraphics.FillEllipse(whiteBrush, 140, 173, 10, 10);
            Thread.Sleep(1000);
            player21.Play();
            formGraphics.FillEllipse(whiteBrush, 149, 166, 10, 10);
            Thread.Sleep(1000);
            player22.Play();
            formGraphics.FillEllipse(whiteBrush, 117, 239, 10, 10);
            Thread.Sleep(1000);
            player23.Play();
            formGraphics.FillEllipse(whiteBrush, 182, 230, 10, 10);
            Thread.Sleep(1000);
            player11.Play();
            formGraphics.FillEllipse(whiteBrush, 228, 111, 10, 10);
            Thread.Sleep(1000);
            player12.Play();
            formGraphics.FillEllipse(whiteBrush, 226, 121, 10, 10);
            Thread.Sleep(1000);
            player13.Play();
            formGraphics.FillEllipse(whiteBrush, 221, 145, 10, 10);
            Thread.Sleep(1000);
            player14.Play();
            formGraphics.FillEllipse(whiteBrush, 214, 151, 10, 10);
            Thread.Sleep(1000);
            player15.Play();
            formGraphics.FillEllipse(whiteBrush, 228, 96, 10, 10);
            Thread.Sleep(1000);
            player16.Play();
            formGraphics.FillEllipse(whiteBrush, 218, 86, 10, 10);
            Thread.Sleep(1000);

            //Sounds played when lines are drawn
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.letsgo);
            SoundPlayer player3 = new SoundPlayer(Properties.Resources.Doh);
            SoundPlayer player4 = new SoundPlayer(Properties.Resources.haha);
            SoundPlayer player5 = new SoundPlayer(Properties.Resources.Boing);
            SoundPlayer player6 = new SoundPlayer(Properties.Resources.hoo);
            SoundPlayer player7 = new SoundPlayer(Properties.Resources.hoohoo);
            SoundPlayer player8 = new SoundPlayer(Properties.Resources.waha);
            SoundPlayer player9 = new SoundPlayer(Properties.Resources.yahoo);
            SoundPlayer player10 = new SoundPlayer(Properties.Resources.yippe);

            //Drawing the lines to connect the stars
            player2.Play();
            Thread.Sleep(2000);
            player3.Play();
            formGraphics.DrawLine(whitePen, 69, 25, 90, 17);
            Thread.Sleep(1000);
            player4.Play();
            formGraphics.DrawLine(whitePen, 73, 25, 76, 58);
            Thread.Sleep(1000);
            player5.Play();
            formGraphics.DrawLine(whitePen, 94, 15, 87, 58);
            Thread.Sleep(1000);
            player6.Play();
            formGraphics.DrawLine(whitePen, 77, 60, 94, 94);
            Thread.Sleep(1000);
            player7.Play();
            formGraphics.DrawLine(whitePen, 95, 94, 107, 112);
            Thread.Sleep(1000);
            player8.Play();
            formGraphics.DrawLine(whitePen, 107, 114, 145, 95);
            Thread.Sleep(1000);
            player9.Play();
            formGraphics.DrawLine(whitePen, 145, 92, 163, 119);
            Thread.Sleep(1000);
            player10.Play();
            formGraphics.DrawLine(whitePen, 167, 119, 155, 167);
            Thread.Sleep(1000);
            player3.Play();
            formGraphics.DrawLine(whitePen, 155, 171, 133, 185);
            Thread.Sleep(1000);
            player4.Play();
            formGraphics.DrawLine(whitePen, 134, 185, 109, 112);
            Thread.Sleep(1000);
            player5.Play();
            formGraphics.DrawLine(whitePen, 136, 185, 122, 247);
            Thread.Sleep(1000);
            player6.Play();
            formGraphics.DrawLine(whitePen, 122, 246, 183, 236);
            Thread.Sleep(1000);
            player7.Play();
            formGraphics.DrawLine(whitePen, 185, 236, 156, 167);
            Thread.Sleep(1000);
            player8.Play();
            formGraphics.DrawLine(whitePen, 163, 121, 230, 114);
            Thread.Sleep(1000);
            player9.Play();
            formGraphics.DrawLine(whitePen, 234, 114, 232, 97);
            Thread.Sleep(1000);
            player10.Play();
            formGraphics.DrawLine(whitePen, 231, 97, 218, 90);
            Thread.Sleep(1000);
            player3.Play();
            formGraphics.DrawLine(whitePen, 233, 114, 233, 123);
            Thread.Sleep(1000);
            player4.Play();
            formGraphics.DrawLine(whitePen, 232, 123, 226, 148);
            Thread.Sleep(1000);
            player5.Play();
            formGraphics.DrawLine(whitePen, 226, 148, 214, 157);
            Thread.Sleep(1000);

            //Drawing the paragraph that describes the constellation
            Font orionFont = new Font("Arial", 8, FontStyle.Bold);
            fg.DrawString("Orion is a prominent constellation located on the celestial equator", orionFont, whiteBrush, 10, 300);
            Thread.Sleep(1000);
            fg.DrawString("and visible throughout the world. It is one of the most conspicuous", orionFont, whiteBrush, 10, 320);
            Thread.Sleep(1000);
            fg.DrawString("and recognizable constellations in the night sky. It was named after", orionFont, whiteBrush, 10, 340);
            Thread.Sleep(1000);
            fg.DrawString("Orion, a hunter in Greek mythology.", orionFont, whiteBrush, 10, 360);
            Thread.Sleep(3000);

            //Setting up the flashing colors for this text
            Font idubbbzFont = new Font("Arial", 8, FontStyle.Bold);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            
            //Playing a sound when the text appears
            SoundPlayer player = new SoundPlayer(Properties.Resources.iDubbbz);
            player.Play();

            //Drawing the text in different colors
            Thread.Sleep(1500);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, whiteBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, redBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, blueBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, yellowBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, greenBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, orangeBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, redBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, blueBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, yellowBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, greenBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, orangeBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, redBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, blueBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, yellowBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, greenBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, orangeBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, redBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, blueBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, yellowBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, greenBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, orangeBrush, 125, 500);
            Thread.Sleep(100);
            fg.DrawString("Hey, That's Pretty Good!", idubbbzFont, whiteBrush, 125, 500);
            Thread.Sleep(5000);
        }
    }
}
