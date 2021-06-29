using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TAiFYa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("3.	Преобразуйте контекстно-свободную грамматику в эквивалентную грамматику, не содержащую бесполезных символов.");
        }

        private void b1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "T:\\Progi!\\TAiFYa";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(ofd.FileName))
                {
                    Core core = new Core(reader.ReadToEnd().Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
                    tb1.Text = core.StartGram();
                    tb2.Text = core.SubGram();
                    tb3.Text = core.FinalGram();
                }
            }
        }
    }
}
