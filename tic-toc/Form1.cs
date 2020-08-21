using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_toc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hod = 0;
        string Player()
        {
            if (++hod % 2 == 0)
                return "O";
            else
                return "X";
        }

        string CheckWin()
        {
            if (button1.Text != "" && button1.Text == button2.Text && button1.Text == button3.Text)
                return button1.Text;
            if (button4.Text != "" && button4.Text == button5.Text && button4.Text == button6.Text)
                return button4.Text;
            if (button7.Text != "" && button7.Text == button8.Text && button7.Text == button9.Text)
                return button7.Text;
            if (button1.Text != "" && button1.Text == button4.Text && button1.Text == button7.Text)
                return button1.Text;
            if (button2.Text != "" && button2.Text == button5.Text && button2.Text == button8.Text)
                return button2.Text;
            if (button3.Text != "" && button3.Text == button6.Text && button3.Text == button9.Text)
                return button3.Text;
            if (button1.Text != "" && button1.Text == button5.Text && button1.Text == button9.Text)
                return button1.Text;
            if (button3.Text != "" && button3.Text == button5.Text && button3.Text == button7.Text)
                return button3.Text;
            if (hod % 9 == 0)
                return "Дружбы";
            else
                return "";
        }
        void Restart()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (sender.GetType().GetProperty("Text").GetValue(sender) == "")
            {
                sender.GetType().GetProperty("Text").SetValue(sender, Player());
                if (CheckWin() != "")
                {
                    MessageBox.Show("Победа " + CheckWin());
                    Restart();
                }
            }
        }
    }
}
