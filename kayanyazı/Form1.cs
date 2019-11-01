using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kayanyazı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string yazi="";
        string ilkharf;
        string ilk;

        private void timer1_Tick(object sender, EventArgs e)
        {
          ilkharf =yazi.Substring(0, 1);
          yazi = yazi.Remove(0, 1);
          yazi = yazi + ilkharf;
          label1.Text = yazi.ToString();
       }

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            yazi =" "+ textBox1.Text.ToUpper();
            label1.Text = yazi.ToString();
             timer1.Start();
        }
    }
}
