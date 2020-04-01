using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projector
{


    public partial class Form1 : Form
    {

        string[,] a =   {{ "shrek.wmf", "death.wmf", "car.wmf" },
                        { "tiger.wmf", "wolf.wmf", "circus.wmf" },
                        { "shit.wmf", "starcraft.wmf", "c#.wmf" },
                        { "DarkSouls.wmf", "you.wmf", "Died.wmf" } };
        string[,] b = {{ "car", "death", "shrek" },
                        { "wolf", "circus", "tiger" },
                         { "starcraft","SHIT","C#" },
                        { "You", "died", "DarkSouls" }};
        int check1, check2, check3;

        int[,] check = {
        //  {1,2,3},
          {3,2,1},
          {3,1,2},
          {2,1,3},
          {3,1,2}
};
        int ShiftX, ShiftY;
        public int i=0, score=0;
        int left1, left2, left3;
        int top1, top2, top3;
        bool IsDown1,IsDown2,IsDown3;
        int k = 4;
        

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            score = (score * 100) / k;

            MessageBox.Show((score) + " балів");

        
            Close();
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IsDown1 = true;
        }

        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            IsDown2 = true;
        }

        private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Control c2 = sender as Control;
            if (IsDown2)
            {

                c2.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void PictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            IsDown2 = false;
        }

        private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            IsDown3 = true;
        }

        private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            Control c3 = sender as Control;
            if (IsDown3)
            {

                c3.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void PictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            IsDown3 = false;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (IsDown1)
            {

                c.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            
            if (IsItIN(pictureBox1, panel1))
                check1 = 1;
            if (IsItIN(pictureBox1, panel2))
                check1 = 2;
            if (IsItIN(pictureBox1, panel3))
                check1 = 3;

            if (IsItIN(pictureBox2, panel1))
                check2 = 1;
            if (IsItIN(pictureBox2, panel2))
                check2 = 2;
            if (IsItIN(pictureBox2, panel3))
                check2 = 3;

            if (IsItIN(pictureBox3, panel1))
                check3 = 1;
            if (IsItIN(pictureBox3, panel2))
                check3 = 2;
            if (IsItIN(pictureBox3, panel3))
                check3 = 3;

            if (check[i, 0] == check1 && check[i, 1] == check2 && check[i, 2] == check3)
            {
                MessageBox.Show("OK");
                score += 1;
                // SetPicture();
            }
            else
            {
                MessageBox.Show("Not OK");
            }

            if (i < 3)
                i++;
            else
            {
                score = (score * 100) / k;
                MessageBox.Show((score) + " балів");

                Close();
            }


            label1.Text = b[i, 0];
                label2.Text = b[i, 1];
                label3.Text = b[i, 2];

                string link1 = "C:/Users/user/source/repos/Projector/bin/Debug/Images/"+a[i, 0];
                pictureBox1.Image = Image.FromFile(link1);
                string link2 = "C:/Users/user/source/repos/Projector/bin/Debug/Images/" + a[i, 1];
                pictureBox2.Image = Image.FromFile(link2);
                string link3 = "C:/Users/user/source/repos/Projector/bin/Debug/Images/" + a[i, 2];
                pictureBox3.Image = Image.FromFile(link3);

            progressBar1.Value = 100;

                pictureBox1.Left = left1;
                pictureBox2.Left = left2;
                pictureBox3.Left = left3;

                pictureBox1.Top = top1;
                pictureBox2.Top = top2;
                pictureBox3.Top = top3;
            timer1.Enabled = true;
            timer2.Enabled = true;
            button1.Enabled = false;

            
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsDown1 = false;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            timer2.Interval = count;

            if (IsItIN(pictureBox1, panel1) ^ IsItIN(pictureBox2, panel1) ^ IsItIN(pictureBox3, panel1) && IsItIN(pictureBox1, panel2) ^ IsItIN(pictureBox2, panel2) ^ IsItIN(pictureBox3, panel2) && IsItIN(pictureBox1, panel3) ^ IsItIN(pictureBox2, panel3) ^ IsItIN(pictureBox3, panel3))
            {
                button1.Enabled = true;

            }
            else
                button1.Enabled = false;
            if (progressBar1.Value == 0)
            {
                MessageBox.Show("Loser");
                //SetPicture();

                label1.Text = b[i, 0];
                label2.Text = b[i, 1];
                label3.Text = b[i, 2];

                MessageBox.Show(a[i,1]);
                string link1 = "C:/Users/user/source/repos/Projector/bin/Debug/Images/" + a[i, 0];
                pictureBox1.Image = Image.FromFile(link1);
                string link2 = "C:/Users/user/source/repos/Projector/bin/Debug/Images/" + a[i, 1];
                pictureBox2.Image = Image.FromFile(link2);
                string link3 = "C:/Users/user/source/repos/Projector/bin/Debug/Images/" + a[i, 2];
                pictureBox3.Image = Image.FromFile(link3);

                progressBar1.Value = 100;

                pictureBox1.Left = left1;
                pictureBox2.Left = left2;
                pictureBox3.Left = left3;

                pictureBox1.Top = top1;
                pictureBox2.Top = top2;
                pictureBox3.Top = top3;
                timer1.Enabled = true;
                timer2.Enabled = true;
                button1.Enabled = false;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            button1.Enabled = false;
            progressBar1.Value = 100;


            left1 = pictureBox1.Left;
            left2 = pictureBox2.Left;
            left3 = pictureBox3.Left;
            top1  = pictureBox1.Top;
            top2  = pictureBox2.Top;
            top3  = pictureBox3.Top;
            //SetPicture();

            label1.Text = b[i, 0];
            label2.Text = b[i, 1];
            label3.Text = b[i, 2];

            string link1 = "C:/Users/user/source/repos/Projector/bin/Debug/Images/" + a[i, 0];
            pictureBox1.Image = Image.FromFile(link1);
            string link2 = "C:/Users/user/source/repos/Projector/bin/Debug/Images/" + a[i, 1];
            pictureBox2.Image = Image.FromFile(link2);
            string link3 = "C:/Users/user/source/repos/Projector/bin/Debug/Images/" + a[i, 2];
            pictureBox3.Image = Image.FromFile(link3);

            progressBar1.Value = 100;

            pictureBox1.Left = left1;
            pictureBox2.Left = left2;
            pictureBox3.Left = left3;

            pictureBox1.Top = top1;
            pictureBox2.Top = top2;
            pictureBox3.Top = top3;
            timer1.Enabled = true;
            timer2.Enabled = true;
            button1.Enabled = false;

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (label4.Visible == true)
                label4.Visible = false;
            else
                label4.Visible = true;

            

            if (progressBar1.Value >= 1)
                progressBar1.Value -= 1;
            else
                MessageBox.Show("Time over");
        }


       public static bool IsItIN(PictureBox TImage, Panel TShape)
        {
            if (TImage.Left >= TShape.Left && TImage.Left + TImage.Width <= TShape.Left + TShape.Width && TImage.Top >= TShape.Top && TImage.Top + TImage.Height <= TShape.Top + TShape.Height)
            {
                return true;
               }
            else return false;
        }
            
    }
}
