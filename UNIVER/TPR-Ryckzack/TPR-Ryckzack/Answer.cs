using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR_Ryckzack
{
    class Answer
    {
        public Answer()
        {
        }
        private static bool[] GetBinaryRepresentation(Int64 i) //перевод из 10 в 2
        {
            List<bool> result = new List<bool>();
            while (i > 0)
            {
                Int64 m = i % 2;
                i = i / 2;
                result.Add(m == 1);
            }
            //result.Reverse();
            return result.ToArray();
        }

        public List<object> FindAns(DataGridView dgv,int maxWeight)
        {
            Int64 variants = (int)Math.Pow((double)2, (double)dgv.Rows.Count);
            int weight = 0,
                price = 0,
                weightWin = 0,
                priceWin = 0;
            string indexes = "",
                   indexesWin = "";
            List<object> listWin = new List<object>();

            for (int i = 0; i < variants; i++)
            {
                weight = 0; price = 0; indexes = "";
                bool[] binar = GetBinaryRepresentation(i);
                for (int j = 0; j < binar.Length; j++)
                {
                    if (binar[j])
                    {
                        weight += (int)dgv.Rows[j].Cells[2].Value;
                        price += (int)dgv.Rows[j].Cells[1].Value;
                        indexes += " " + dgv.Rows[j].Cells[0].Value;
                    }
                }
                if (weight<=maxWeight&&price>priceWin)
                {
                    weightWin = weight;
                    priceWin = price;
                    indexesWin = indexes;
                }
            }
            listWin.Add(weightWin);
            listWin.Add(priceWin);
            listWin.Add(indexesWin);
            return listWin;
        }
    }
}
