using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

/*public class Element
{
    string key;
    string value;
    Element[] childs;
}*/

namespace Задача_5_
{
    public partial class Proga : Form
    {
        public Proga()
        {
            InitializeComponent();
        }

        private void Vvod_Click(object sender, EventArgs e)
        {      
            Stream myStream = null;
            OpenFileDialog vibor = new OpenFileDialog();
            Vibor.InitialDirectory = "f:\\";
            Vibor.FileName = "Translate";
            Vibor.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            Vibor.FilterIndex = 2;
            Vibor.RestoreDirectory = true;
            if (Vibor.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = Vibor.OpenFile()) != null)
                    {
                        using (myStream)
                        {

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:"+ ex.Message);
                }
            }
            try
            {
                FileStream aFile =
                   new FileStream(Vibor.FileName,
                      FileMode.Open);
                StreamReader f =
                    new StreamReader(aFile, Encoding.GetEncoding("windows-1251"));
                Kod.f = f;
                Otvet.Text = "Ответ:";
                Otvet.Text += Kod.translate(Okno1.Text,Okno2.Text);
                if (Otvet.Text.Length==6)
                 Otvet.Text+= "Там пусто или ошибка в yml таблице";
                f.Close();
                
                aFile.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error:"+ex.Message);
            }
        }
    }
}
