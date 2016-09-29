using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeUI
{
    public partial class Form1 : Form
    {

        bool turn = true; // true = x turn, false = y turn

        public Form1()
        {
            InitializeComponent();
        }
        private void A1_Click(object sender, EventArgs e)
        {
            //char crossOrCircle = 'X';

            MessageBox.Show("X");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
