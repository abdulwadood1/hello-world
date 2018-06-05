using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrmAppGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int plyr = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            lbPlyr1.Text = "Player-1";
        }

        private void R11_Click(object sender, EventArgs e)
        {
            plyr++;

            int rmd = plyr % 2;

            Button btn = sender as Button;

            if (rmd > 0)
            {
                //odd no need to display x symbole on 
                btn.Text = "X";
            }
            else
            { 
                //even no need to display 0 symbole on button
                btn.Text = "0";
            }
        }
    }
}
