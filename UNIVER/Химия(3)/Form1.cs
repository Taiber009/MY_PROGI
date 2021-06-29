using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Химия_3_
{
    public partial class Proga : Form
    {
        public Proga()
        {
            InitializeComponent();
            for (int i = 48; i < 58; i++)
                num.Add((char)i);
            for (int i = 65; i < 91; i++)
                big.Add((char)i);
            for (int i = 97; i < 123; i++)
                small.Add((char)i);
        }

        bool b = true;
        Mol mol1 = new Mol();
        Mol mol2 = new Mol();
        Atoms[] list = new Atoms[0];
        Ions[] list2 = new Ions[0];
        private HashSet<char> big = new HashSet<char>();
        private HashSet<char> small = new HashSet<char>();
        private HashSet<char> num = new HashSet<char>();


        private void FP_CheckedChanged(object sender, EventArgs e)
        {
            b = true;
        }
        private void SP_CheckedChanged(object sender, EventArgs e)
        {
            b = false;
        }
        private void Fast_Click(object sender, EventArgs e)
        {/*
            Array.Resize<Ions>(ref list, l + 4);
            list[l++] = new Ions(-2, 1, "SO4");//y=1
            IonsBox.Items.Add(l + ")" + "SO4" + '(' + -2 + ')');
            list[l++] = new Ions(-1, 1, "Cl");//y=1
            IonsBox.Items.Add(l + ")" + "Cl" + '(' + -1 + ')');
            list[l++] = new Ions(1, 1, "H");//y=1
            IonsBox.Items.Add(l + ")" + "H" + '(' + 1 + ')');
            list[l++] = new Ions(1, 1, "Na");//y=1
            IonsBox.Items.Add(l + ")" + "Na" + '(' + 1 + ')');
            */
            ElecBox.Text = ProBox.Text;
            NeutBox.Text = ProBox.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddAtoms_Click(object sender, EventArgs e)
        {
            string Name = Box1.Text;
            int P = Int32.Parse(ProBox.Text);
            int E = Int32.Parse(ElecBox.Text);
            int N = Int32.Parse(NeutBox.Text);
            bool new_atom = true;//ПОСТРОЕНИЕ АТОМА!!!!!!
            Atoms cache = new Atoms(Name, P, E, N);
            for (int i = 0; i < list.Length; i++)
                if (list[i] == cache)
                {//перезапись aтома в списке
                    // list[i] = new Atoms(Name, P, E, N);
                    // AtomsBox.Items.Remove(i);
                    // AtomsBox.Items[i] = ((i + 1) + ")" + Name + "(П:" + P + "; Э:" + E + "; Н:" + N + "; Заряд:" + list[i].charge + "; Вес:" + list[i].weight + ')');
                    ////AtomsBox.Items.Add((i+1) + ")" + Name + "(П:" + P + "; Э:" + E + "; Н:" + N + "; Заряд:" + list[i].charge + "; Вес:" + list[i].weight + ')');
                    new_atom = false;
                    break;
                }
            if (new_atom)
            {//новый атома
                Array.Resize<Atoms>(ref list, list.Length + 1);
                list[list.Length - 1] = cache;
                //L++;?
                AtomsBox.Items.Add(list.Length + ")" + Name + "(П:" + P + "; Э:" + E + "; Н:" + N + "; Заряд:" + list[list.Length - 1].Charge() + "; Вес:" + list[list.Length - 1].Weight() + ')');
            }
            AtomsBox.SelectedIndex = list.Length - 1;
            ProBox.Text = 0 + "";
            ElecBox.Text = 0 + "";
            NeutBox.Text = 0 + "";
            Box1.Text = "";
        }
        private void AddIons_Click(object sender, EventArgs e)
        {
            Ions cache = new Ions();
            string s = NewIon.Text + ' ';
            string s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (num.Contains(s[i]))
                {
                    s1 += s[i];
                    if ((big.Contains(s[i + 1])) || s[i + 1] == ' ')
                    {
                        cache.Ats[cache.Ats.Length - 1].count = Int32.Parse(s1);
                        s1 = "";
                    }
                }
                else if (big.Contains(s[i]))
                {
                    s1 += s[i];
                    if ((big.Contains(s[i + 1])) || (num.Contains(s[i + 1])) || s[i + 1] == ' ')
                        for (int j = 0; j < list.Length; j++)
                            if (s1 == list[j].Name())
                            {
                                cache.New(list[j]);
                                s1 = "";
                                break;
                            }
                }
                else if (small.Contains(s[i]))
                {
                    s1 += s[i];
                    //if (s[i + 1] == ' ')
                    for (int j = 0; j < list.Length; j++)
                        if (s1 == list[j].Name())
                        {
                            cache.New(list[j]);
                            s1 = "";
                            break;
                        }
                }
            }
            //if (l >= list.Length)
            Array.Resize<Ions>(ref list2, list2.Length + 1);
            list2[list2.Length - 1] = cache;// new Ions(cache);
            //L++;?
            IonsBox.Items.Add(list2.Length + ")" + NewIon.Text + "(Заряд:" + cache.Charge() + ", Вес:" + cache.Weight() + ")");
            IonsBox.SelectedIndex = list2.Length - 1;
            NewIon.Text = "";

        }
        private void AddMol_Click(object sender, EventArgs e)
        {
            Ions I = list2[IonsBox.SelectedIndex];
            if (b)//первая молекула
            {
                if (I.Charge() > 0)//положительная часть
                    if (mol1.pos == I)
                        mol1.pos.count++;
                    else
                        mol1.pos = I;
                else //отрицательная
                    if (mol1.neg == I)
                        mol1.neg.count++;
                    else
                        mol1.neg = I;
                Mol1Text.Text = mol1.Name();
            }
            else//вторая молекула
            {
                if (I.Charge() > 0)
                    if (mol2.pos == I)
                        mol2.pos.count++;
                    else
                        mol2.pos = I;
                else
                    if (mol2.neg == I)
                        mol2.neg.count++;
                    else
                        mol2.neg = I;
                Mol2Text.Text = mol2.Name();
            }
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Ions cache = new Ions();
            int m1p = mol1.pos.Charge(),
                m1n = mol1.neg.Charge(),
                m2p = mol2.pos.Charge(),
                m2n = mol2.neg.Charge();
            if ((m1p == -1 * m1n) && (m2p == -1 * m2n))
                if ((m1p == m2p) && (m1n == m2n))
                {//рекация обмена
                    cache = mol1.pos;
                    mol1.pos = mol2.pos;
                    mol2.pos = cache;
                    Result.Text = mol1.Name() + '+' + mol2.Name();
                }
                else
                    Result.Text = "Первая и вторая молекулы неравны";
            else if ((m1p != -1 * m1n) && (m2p != -1 * m2n))
                Result.Text = "Первая и вторая молекулы неполные";
            else if (m1p != -1 * m1n)
                Result.Text = "Первая молекула неполная";
            else if (m2p != -1 * m2n)
                Result.Text = "Вторая молекула неполная";
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (b)//первая молекула
            {
                mol1 = new Mol();
                Mol1Text.Text = ".";
            }
            else//вторая молекула
            {
                mol2 = new Mol();
                Mol2Text.Text = ".";
            }
        }

        private void ProPlus_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(ProBox.Text);
            ProBox.Text = "" + (i + 1);
        }
        private void ElecPlus_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(ElecBox.Text);
            ElecBox.Text = "" + (i + 1);
        }
        private void NeutPlus_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(NeutBox.Text);
            NeutBox.Text = "" + (i + 1);
        }
        private void ProMinus_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(ProBox.Text);
            if (i != 0)
                ProBox.Text = "" + (i - 1);
        }
        private void ElecMinus_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(ElecBox.Text);
            if (i != 0)
                ElecBox.Text = "" + (i - 1);
        }
        private void NeutMinus_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(NeutBox.Text);
            if (i != 0)
                NeutBox.Text = "" + (i - 1);
        }

        private void MySave_Click(object sender, EventArgs e)
        {
            string save = "";
            //save += "mol1:"+Environment.NewLine;
            // save += " pos:" + Environment.NewLine;
            save += 1 + "/" + mol1.pos.count + Environment.NewLine + SaveFunc(mol1.pos.Ats);//можно всю строку(кроме первого числа) в SaveFunc запихнуть,
            save += 2 + "/" + mol1.neg.count + Environment.NewLine + SaveFunc(mol1.neg.Ats);//но так нагляднее
            save += 3 + "/" + mol2.pos.count + Environment.NewLine + SaveFunc(mol2.pos.Ats);
            save += 4 + "/" + mol2.neg.count + Environment.NewLine + SaveFunc(mol2.neg.Ats);
            save += 5 + "/" + "1" + Environment.NewLine + SaveFunc(list);
            for (int i = 0; i < list2.Length; i++)
            {
                save += (i + 1) * 10 + "/" + 1 + Environment.NewLine + SaveFunc(list2[i].Ats);
            }
            SFD.InitialDirectory = "c:\\";
            SFD.Filter = "txt files (*.txt)|*.txt";
            SFD.FilterIndex = 1;
            SFD.RestoreDirectory = true;
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(@SFD.FileName, save);
            }
        }
        private string SaveFunc(Atoms[] Ats)
        {
            string str = "";
            foreach (Atoms i1 in Ats)
            {
                int p = 0, n = 0, e = 0;
                str += i1.Name() + "/" + i1.count;
                foreach (Element i2 in i1.Els)
                {
                    if (i2.Charge() == 1) //switch?
                        p++;
                    else if (i2.Charge() == 0)
                        n++;
                    else
                        e++;
                    //while (i2.name == "Протон")
                    //   i++;
                    // str += i2.name[0] + " ";
                }
                str += "/" + p + "/" + e + "/" + n;
                str += Environment.NewLine;
            }
            return str;
        }
        private void MyLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string[] load;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                {
                    if (OFD.OpenFile() != null)
                    {////////////////////////////////
                        load = System.IO.File.ReadAllLines(@OFD.FileName);
                        mol1 = new Mol();
                        mol2 = new Mol();
                        list = new Atoms[0];
                        list2 = new Ions[0];
                        AtomsBox.Items.Clear();
                        IonsBox.Items.Clear();
                        //int sw2;
                        Ions I = mol1.pos;
                        foreach (string s in load)
                        {
                            string[] spl = s.Split('/');
                            if (big.Contains(spl[0][0]))//строка - атом
                            {
                                //int c;
                                // if (spl.Length > 1) c = Int32.Parse(spl[1]);
                                // else                c = 0;//если лист атомов(всегда cou
                                // for (int i = 0; i < c; i++)
                                I.New(new Atoms(spl[0], //name
                                    Int32.Parse(spl[2]), //prot
                                    Int32.Parse(spl[3]), //elec
                                    Int32.Parse(spl[4]),//neut
                                    Int32.Parse(spl[1])));//

                            }
                            else if (num.Contains(s[0]))//строка - ион
                            {
                                switch (spl[0])//выбор иона
                                {
                                    case ("1"):
                                        //I = mol1.pos;//изначально указывает при объявлении
                                        break;
                                    case ("2"):
                                        I = mol1.neg;
                                        break;
                                    case ("3"):
                                        I = mol2.pos;
                                        break;
                                    case ("4"):
                                        I = mol2.neg;
                                        break;
                                    case ("5"):
                                        I = new Ions();//отсюда нужен только массив атомов, тк это сохранение для листа атомов
                                        break;
                                    default://дальше (10, 20...) идет объявление ионов из листа ионов
                                        if (list.Length == 0)//только что запарсили лист атомов(5) и перешли в лист ионов(10,20..)
                                            list = I.Ats;//ссылка на массив атомов для листа атомов
                                        Array.Resize<Ions>(ref list2, list2.Length + 1);
                                        list2[list2.Length - 1] = new Ions();
                                        I = list2[Int32.Parse(spl[0]) / 10 - 1];//10=list2[0] итд
                                        break;
                                }
                                if (spl[1] != "1")
                                    I.count = Int32.Parse(spl[1]);
                            }
                            else
                                MessageBox.Show("Name atom error!-> " + s);
                        }
                        MessageBox.Show("Был загружен файл " + '"' + OFD.SafeFileName + '"');
                        //вывод на форму всех данных
                        if (mol1.Weight() != 0)
                            Mol1Text.Text = mol1.Name();
                        if (mol2.Weight() != 0)
                            Mol2Text.Text = mol2.Name();
                        for (int i = 0; i < list.Length; i++)
                            AtomsBox.Items.Add((i + 1) + ")" + list[i].Name() + "(П:" + list[i].Pcount + "; Э:" + list[i].Ecount + "; Н:" + list[i].Ncount + "; Заряд:" + list[i].Charge() + "; Вес:" + list[i].Weight() + ')');
                        for (int i = 0; i < list2.Length; i++)
                            IonsBox.Items.Add((i + 1) + ")" + list2[i].Name() + "(Заряд:" + list2[i].Charge() + ", Вес:" + list2[i].Weight() + ")");
                        AtomsBox.SelectedIndex = list.Length - 1;
                        IonsBox.SelectedIndex = list2.Length - 1;
                    }
                }
                //catch (Exception ex)
                // {
                //     MessageBox.Show("Error:" + ex.Message);
                // }
            }
        }

        private void OFD_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void SFD_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AtomsBox.SelectedIndex >= 0)
            {
                list[AtomsBox.SelectedIndex] = null;
                AtomsBox.Items[AtomsBox.SelectedIndex] = "Null";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IonsBox.SelectedIndex >= 0)
            {
                list2[IonsBox.SelectedIndex] = null;
                IonsBox.Items[IonsBox.SelectedIndex] = "Null";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kkk;
        }
    }
}
