using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye = 0;

        private void checkBoxFcb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {


                timer1.Enabled = true;
                checkBoxRma.Checked = false;
                checkBoxGs.Checked = false;
                checkBoxGarabag.Checked = false;
                timer1.Enabled = true;
                axWindowsMediaPlayer1.URL = "C:\\Users\\hp\\Desktop\\fcb.mp3";
            }

            catch
            {
                MessageBox.Show("Xəta baş verdi!");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            try
            {
                saniye = Convert.ToInt32(label1.Text);
                saniye++;
                label1.Text = saniye.ToString();

                if (checkBoxFcb.Checked == true)
                {




                    if (saniye % 10 == 0)
                    {
                        button1.BackColor = Color.Red;
                        button4.BackColor = Color.Red;
                        button7.BackColor = Color.Red;
                        button3.BackColor = Color.Red;
                        button6.BackColor = Color.Red;
                        button9.BackColor = Color.Red;
                        button2.BackColor = Color.Blue;
                        button5.BackColor = Color.Blue;
                        button8.BackColor = Color.Blue;
                        button10.BackColor = Color.Blue;
                        button11.BackColor = Color.Blue;
                        button12.BackColor = Color.Blue;

                    }
                    if (saniye % 10 == 5)
                    {
                        button1.BackColor = Color.Blue;
                        button4.BackColor = Color.Blue;
                        button7.BackColor = Color.Blue;
                        button3.BackColor = Color.Blue;
                        button6.BackColor = Color.Blue;
                        button9.BackColor = Color.Blue;
                        button2.BackColor = Color.Red;
                        button5.BackColor = Color.Red;
                        button8.BackColor = Color.Red;
                        button10.BackColor = Color.Red;
                        button11.BackColor = Color.Red;
                        button12.BackColor = Color.Red;















                    }
                }

                if (checkBoxRma.Checked == true)
                {




                    if (saniye % 10 == 0)
                    {
                        button1.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button7.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button6.BackColor = Color.White;
                        button9.BackColor = Color.White;
                        button2.BackColor = Color.Black;
                        button5.BackColor = Color.Black;
                        button8.BackColor = Color.Black;
                        button10.BackColor = Color.Black;
                        button11.BackColor = Color.Black;
                        button12.BackColor = Color.Black;

                    }
                    if (saniye % 10 == 5)
                    {
                        button1.BackColor = Color.Black;
                        button4.BackColor = Color.Black;
                        button7.BackColor = Color.Black;
                        button3.BackColor = Color.Black;
                        button6.BackColor = Color.Black;
                        button9.BackColor = Color.Black;
                        button2.BackColor = Color.White;
                        button5.BackColor = Color.White;
                        button8.BackColor = Color.White;
                        button10.BackColor = Color.White;
                        button11.BackColor = Color.White;
                        button12.BackColor = Color.White;















                    }
                }

                if (checkBoxGarabag.Checked == true)
                {




                    if (saniye % 10 == 0)
                    {
                        button1.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button7.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button6.BackColor = Color.White;
                        button9.BackColor = Color.White;
                        button2.BackColor = Color.Black;
                        button5.BackColor = Color.Black;
                        button8.BackColor = Color.Black;
                        button10.BackColor = Color.Black;
                        button11.BackColor = Color.Black;
                        button12.BackColor = Color.Black;

                    }
                    if (saniye % 10 == 5)
                    {
                        button1.BackColor = Color.Black;
                        button4.BackColor = Color.Black;
                        button7.BackColor = Color.Black;
                        button3.BackColor = Color.Black;
                        button6.BackColor = Color.Black;
                        button9.BackColor = Color.Black;
                        button2.BackColor = Color.White;
                        button5.BackColor = Color.White;
                        button8.BackColor = Color.White;
                        button10.BackColor = Color.White;
                        button11.BackColor = Color.White;
                        button12.BackColor = Color.White;















                    }
                }
                if (checkBoxGs.Checked == true)
                {




                    if (saniye % 10 == 0)
                    {
                        button1.BackColor = Color.Yellow;
                        button4.BackColor = Color.Yellow;
                        button7.BackColor = Color.Yellow;
                        button3.BackColor = Color.Yellow;
                        button6.BackColor = Color.Yellow;
                        button9.BackColor = Color.Yellow;
                        button2.BackColor = Color.Red;
                        button5.BackColor = Color.Red;
                        button8.BackColor = Color.Red;
                        button10.BackColor = Color.Red;
                        button11.BackColor = Color.Red;
                        button12.BackColor = Color.Red;

                    }
                    if (saniye % 10 == 5)
                    {
                        button1.BackColor = Color.Red;
                        button4.BackColor = Color.Red;
                        button7.BackColor = Color.Red;
                        button3.BackColor = Color.Red;
                        button6.BackColor = Color.Red;
                        button9.BackColor = Color.Red;
                        button2.BackColor = Color.Yellow;
                        button5.BackColor = Color.Yellow;
                        button8.BackColor = Color.Yellow;
                        button10.BackColor = Color.Yellow;
                        button11.BackColor = Color.Yellow;
                        button12.BackColor = Color.Yellow;















                    }
                }
            }
            catch
            {
               
            
             MessageBox.Show("Xəta baş verdi!");
            

        }

    }

        private void checkBoxGs_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFcb.Checked = false;
            checkBoxRma.Checked = false;
            checkBoxGarabag.Checked = false;
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\hp\\Desktop\\gs.mp3";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxRma_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.BackColor = Color.FromArgb(33, 55, 44);
            checkBoxFcb.Checked = false;
            checkBoxGs.Checked = false;
            checkBoxGarabag.Checked = false;
      
            axWindowsMediaPlayer1.URL = "C:\\Users\\hp\\Desktop\\rma.mp3";



        }

        private void checkBoxGarabag_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.BackColor = Color.FromArgb(207, 228, 218);
            checkBoxFcb.Checked = false;
            checkBoxGs.Checked = false;
            checkBoxRma.Checked = false;
        
            axWindowsMediaPlayer1.URL = "C:\\Users\\hp\\Desktop\\grb.mp3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
