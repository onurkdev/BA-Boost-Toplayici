using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA_Boost_Toplayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string input;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input = textBox1.Text;
        }

        private void sumbutton_Click(object sender, EventArgs e)
        {
            string message="";
            int sumnumbers=0;
            char[] chars = input.Trim().ToCharArray();
            foreach (char c in chars) {
                int num;
                try
                {
                    num = Convert.ToInt32(Char.GetNumericValue(c));
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen sadece sayı giriniz");
                    return;
                }
                sumnumbers += num;

                

            }
            foreach (char c in chars) {

                message = message + " + " + c;

            }
            string messagenew = message.Remove(1,1) + " => "+sumnumbers;
            listBox1.Items.Add(messagenew);

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }
    }
}
