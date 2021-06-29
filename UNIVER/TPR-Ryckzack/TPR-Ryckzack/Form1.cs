using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR_Ryckzack
{
    public partial class f : Form
    {
        int maxWeight;
        public f()
        {
            InitializeComponent();
        }

        private void bMaxW_Click(object sender, EventArgs e)
        {
            tbInfo.Text = "";
            try
            {
                maxWeight = Convert.ToInt32(tbMaxW.Text);
                tbMaxW.Text = "";
                lMaxW.Text = "Максимальный вес = " + maxWeight;
            }
            catch (Exception ex)
            {
                tbInfo.Text = ex.ToString();
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            tbInfo.Text = "";
            try
            {
                dgv.Rows.Add(dgv.Rows.Count + 1,
                    Convert.ToInt32(tbP.Text),
                    Convert.ToInt32(tbW.Text));
                    //Convert.ToDouble(tbP.Text) / Convert.ToDouble(tbW.Text));
                tbP.Text = tbW.Text = "";
            }
            catch (Exception ex)
            {
                tbInfo.Text = ex.ToString();
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            try
            {
                string indexes = "";
                int price =0, weight = 0;
                Answer ans = new Answer();
                List<object> list = ans.FindAns(dgv, maxWeight);
                weight = (int)list[0];
                price = (int)list[1];
                indexes=(string)list[2];
                /*
            dgv.Sort(dgv.Columns[3], ListSortDirection.Descending);
            List<double> list = new List<double>();
            for (int i = 0; i < dgv.Rows.Count; i++)
                list.Add((double)dgv.Rows[i].Cells[2].Value);
            bool[] binar,
                winBinar = new bool[0];
            int j = 0;
            double weight = 0,
                price = 0,
                weight_max_from_list = list.Max(),
                secondWeight = 0,
                winSecondWeight = 0;
            string indexes = "";
            while (weight + (double)dgv.Rows[j].Cells[2].Value <= maxWeight - weight_max_from_list)
            {
                indexes += " " + dgv.Rows[j].Cells[0].Value;
                price += (double)dgv.Rows[j].Cells[1].Value;
                weight += (double)dgv.Rows[j].Cells[2].Value;

                if ((double)dgv.Rows[j].Cells[2].Value == weight_max_from_list)
                {
                    list[j] = 0;
                    weight_max_from_list = list.Max();
                }
                j++;
            }

            for (int i = 0; i <= dgv.Rows.Count - j; i++)
            {
                secondWeight = 0;
                binar = GetBinaryRepresentation(i);
                for (int k = 0; k < binar.Length; k++)
                    if (binar[k])
                        secondWeight += (double)dgv.Rows[j + k].Cells[2].Value;
                if (weight + secondWeight < maxWeight && weight + secondWeight > winSecondWeight)
                {
                    winSecondWeight = secondWeight;
                    winBinar = binar;
                }
            }

            weight += winSecondWeight;
            for (int k = 0; k < winBinar.Length; k++)
                if (winBinar[k])
                {
                    price += (double)dgv.Rows[j + k].Cells[1].Value;
                    indexes += " " + dgv.Rows[j+k].Cells[0].Value;
                }


            /*for (int i = 0; i < dgv.Rows.Count; i++)
                if (weight + (double)dgv.Rows[i].Cells[2].Value <= maxWeight)
                {
                    indexes += " " + dgv.Rows[i].Cells[0].Value;
                    price += (double)dgv.Rows[i].Cells[1].Value;
                    weight += (double)dgv.Rows[i].Cells[2].Value;
                }*/
                tbInfo.Text = "Будут выбраны предметы с индексами" + indexes + Environment.NewLine +
                    "Суммарный вес рюкзака получился " + weight + " кг" + Environment.NewLine +
                    "Общая стоимость загруженных предметов " + price + " руб.";
            }
            catch (Exception ex)
            {
                tbInfo.Text = ex.ToString();
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            lMaxW.Text = "Максимальный вес";
            tbMaxW.Text = tbP.Text = tbW.Text = tbInfo.Text = "";
            dgv.Rows.Clear();
            maxWeight = 0;
        }
    }
}
