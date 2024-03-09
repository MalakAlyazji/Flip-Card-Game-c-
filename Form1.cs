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
namespace CardFlipGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum enchoice { choice1,choice2}
        enchoice choice = enchoice.choice1;
        void changepicture(Button bt)
        {
            if (bt.Tag.ToString() == "13")
            {
                bt.Image = Image.FromFile(@"C:\Users\hp\Downloads\13.jpg");
                
            }else if (bt.Tag.ToString() == "29")
            {
                bt.Image = Image.FromFile(@"C:\Users\hp\Downloads\29.jpg");
            }
            else if (bt.Tag.ToString() == "54")
            {
                bt.Image = Image.FromFile(@"C:\Users\hp\Downloads\54.jpg");
            }
            else if (bt.Tag.ToString() == "72")
            {
                bt.Image = Image.FromFile(@"C:\Users\hp\Downloads\72.jpg");
            }
            else if (bt.Tag.ToString() == "86")
            {
                bt.Image = Image.FromFile(@"C:\Users\hp\Downloads\86.jpg");
            }
            else
            {
                bt.Image = Image.FromFile(@"C:\Users\hp\Downloads\99.jpg");
            }
            bt.Enabled = false;
        }
        void checkround(Button bt1,Button bt2)
        { 
            if (bt1.Tag!=bt2.Tag )
            {
                bt1.Image = Image.FromFile(@"C:\Users\hp\Downloads\questionmark.jpg");
                bt2.Image = Image.FromFile(@"C:\Users\hp\Downloads\questionmark.jpg");
                bt2.Enabled = true;
                bt1.Enabled = true;
            }
            else
            {
                count++;
            }
            
        }
        public Button b1;
        int round = 1;
        int count = 0;
        void playround(Button bt)
        {
            switch (choice)
                {
                    case enchoice.choice1:
                         b1=bt;
                         lbchoice2.Text = "?";
                         lbturn.Text = "Ch1";
                         lbchoice1.Text = bt.Tag.ToString();
                        choice = enchoice.choice2;
                        changepicture(bt);
                        break;
                    case enchoice.choice2:
                        lbchoice2.Text = bt.Tag.ToString();
                        choice = enchoice.choice1;
                        changepicture(bt);
                        lbturn.Text = "Ch2";
                    Thread.Sleep(200);
                        checkround(b1, bt);
                    break;
                }
            
        }
        private void button_Click_1(object sender, EventArgs e)
        {
            playround((Button)sender);
        }

        private void btgenerate_Click(object sender, EventArgs e)
        {
            if (count == 6)
            {
                count = 0;
                MessageBox.Show("Great Work! All Done :)\n press generate to play again", "Done ", MessageBoxButtons.OK);
                round++;
                lbchoice1.Text = "?";
                lbchoice2.Text = "?";
                lbround.Text = round.ToString();
                button1.Image = Image.FromFile(@"C:\Users\hp\Downloads\questionmark.jpg");
                button2.Image = Image.FromFile(@"C:\Users\hp\Downloads\questionmark.jpg");
                button3.Image = Image.FromFile(@"C:\Users\hp\Downloads\questionmark.jpg");
                button4.Image = Image.FromFile(@"C:\Users\hp\Downloads\questionmark.jpg");
                button5.Image = Image.FromFile(@"C:\Users\hp\Downloads\questionmark.jpg");
                button6.Image = Image.FromFile(@"C:\Users\hp\Downloads\questionmark.jpg");
                button7.Image = Image.FromFile(@"C:\Users\hp\Downloads\questionmark.jpg");
                button8.Image = Image.FromFile(@"C:\Users\hp\Downloads\questionmark.jpg");
                button9.Image = Image.FromFile(@"C:\Users\hp\Downloads\questionmark.jpg");
                button10.Image = Image.FromFile(@"C:\Users\hp\Downloads\questionmark.jpg");
                button11.Image = Image.FromFile(@"C:\Users\hp\Downloads\questionmark.jpg");
                button12.Image = Image.FromFile(@"C:\Users\hp\Downloads\questionmark.jpg");
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sorry , you cant start a new game without flipping any card", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
