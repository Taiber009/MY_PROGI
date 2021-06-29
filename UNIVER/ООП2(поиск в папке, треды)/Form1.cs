using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ООП2
{
    public partial class OOP2 : Form
    {
        public OOP2()
        {
            InitializeComponent();
        }


        Comparison[] exm = new Comparison[10];
        Thread[] t = new Thread[10];
        public string Union(string[] m)
        {
            string s = "";
            for (int i = 0; i < m.Length; i++)
            {
                s += m[i];
                if (i < m.Length - 1) s += "\r\n";
            }
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otvet.Text = "";
            int k = Int32.Parse(Konst.Text);
            exm = new Comparison[k];
            t = new Thread[k];
           // OpenFileDialog ofd = new OpenFileDialog();
            //string[] load;
            string poisk = Poisk.Text;
            if (FBD.ShowDialog()==DialogResult.OK)
            //if (OFD.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(FBD.SelectedPath);
               // for (int f = 0; f < files.Length;f++)
               // {
                   // OFD.FileName=files[f];
                   // if (OFD.OpenFile() != null)
                    //{
                        for (int i0 = 0; i0 <= files.Length / k; i0++)
                        {
                            for (int i = 0; i < k && k * i0 + i < files.Length; i++)
                            {
                                exm[(i)] = new Comparison(System.IO.File.ReadAllLines(files[k * i0 + i]), poisk);//%k тут нафиг не нужен?
                                t[i] = new Thread(exm[i].Otvet);

                            }

                            for (int i = 0; i < k && k * i0 + i < files.Length; i++)
                            {
                                t[i].Start();
                                Thread.Sleep(1);
                                if (exm[(i)].win)
                                    Otvet.Text += "Нить " + (i) + " нашла совпадение в файле " + files[k * i0 + i] + Environment.NewLine;
                            }
                        }
                        //    load = System.IO.File.ReadAllLines(@OFD.FileName);
                        // string s = Union(load);
                        //OFD.FileNames[1];
                        // if (poisk == s) Otvet.Text += "Было найдено совпадение в " + OFD.FileName;
                   // }
                //}
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
