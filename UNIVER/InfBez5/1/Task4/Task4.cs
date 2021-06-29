namespace RSA
{
    public partial class Task4 : System.Windows.Forms.Form
    {
        public Task4() { InitializeComponent(); }
        private void Dechiper_Click(object sender, System.EventArgs e)
        {
            ulong N = System.Convert.ToUInt64(NTB.Text), e_ = System.Convert.ToUInt64(ETB.Text); string C = CTB.Text;
            int l = N.ToString().Length; System.Collections.ArrayList list = new System.Collections.ArrayList();
            while (C != "")
            {
                int w = (System.Convert.ToUInt64(C.Substring(0, (C.Length > l) ? l : C.Length)) <= N) ? l : l - 1;
                list.Add(C.Substring(0, (C.Length > l) ? w : C.Length)); C = (C.Length > l) ? C.Substring(w) : "";
            }
            ulong t = (ulong)System.Math.Round(System.Math.Sqrt(N)), k = 0, d, p, q;
            while (true)
            {
                ulong y = (t + ++k) * (t + k) - N;
                if ((ulong)System.Math.Sqrt(y) * (ulong)System.Math.Sqrt(y) == y)
                { p = t + k + (ulong)System.Math.Sqrt(y) - 1; q = t + k - (ulong)System.Math.Sqrt(y) - 1; k = 0; break; };
            }
            while (true) if ((1 + ++k * p * q) % e_ == 0) { d = (1 + k * p * q) / e_ % (p * q); break; }
            for (int i = 0; i < list.Count; i++)
                C += ((ulong)System.Numerics.BigInteger.ModPow(System.Convert.ToUInt64(list[i]), d, N)).ToString();
            list.Clear(); while (C != "") { list.Add(C.Substring(0, (C.Length > 2) ? 2 : C.Length)); C = (C.Length > 2) ? C.Substring(2) : ""; }
            for (int i = 0; i < list.Count; i++) C += (char)System.Convert.ToInt32(list[i]);
            DTB.Text = "P: " + (++p).ToString() + "; Q: " + (++q).ToString() + "\r\nd: " + d.ToString() + "\r\nMessage: " + C;
            Dechiper.Enabled = false; Clean.Enabled = true;
        }
        private void Clean_Click(object sender, System.EventArgs e) { Dechiper.Enabled = true; Clean.Enabled = false; DTB.Clear(); }
    }
}