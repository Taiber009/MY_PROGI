using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SUDOKU
{
    public partial class DifficultyForm : Form
    {
        public int diff;
        public DifficultyForm()
        {
            InitializeComponent();
            diff = 0;
        }

        private void BEasy_Click(object sender, EventArgs e)
        {
            diff = 1;
            this.Close();
        }

        private void BMiddle_Click(object sender, EventArgs e)
        {
            diff = 2;
            this.Close();
        }

        private void BHard_Click(object sender, EventArgs e)
        {
            diff = 3;
            this.Close();
        }
    }
}
