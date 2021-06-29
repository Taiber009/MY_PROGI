using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oop.Tasks.Paint.Interface;

namespace ClassLibrary2
{
    public partial class UserControl1 : UserControl
    {
        
        private IPaintApplicationContext applicationContext=null;
        private string[] brushStyleNames=null;
        public UserControl1(IPaintApplicationContext applicationContext) {
            this.applicationContext=applicationContext;
            InitializeComponent();
        }

        Bitmap bit = null;
        public byte t1=24,t2=24;

		protected override void Dispose(bool disposing) {
			if(disposing) {
				if(components!=null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

        //public void Save()
        //{
            //bit = (Bitmap)applicationContext.Image.Clone();//как сейвить???
       //    // MessageBox.Show("Сохранено");
        //}

       // private void Load_Click(object sender, EventArgs e)
       // {
        //    if (bit != null)
         //   { //Bitmap tmp = ;
         //       applicationContext.=(Bitmap)bit.Clone();
         //   }
         //   else
         //       MessageBox.Show("Ничего не сохранено");
        //    applicationContext.Invalidate();
      //  }
        public int Yarkost
        {
            get
            {
                return Int32.Parse(Ya.Text);
            }
        }
        public int Kontrast
        {
            get
            {
                return Int32.Parse(Ko.Text);
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void FU_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(Ya.Text);
            Ya.Text = "" + (i + 1);
        }

        private void FD_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(Ya.Text);
            Ya.Text = "" + (i - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(Ko.Text);
            Ko.Text = "" + (i + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(Ko.Text);
            Ko.Text = "" + (i - 1);
        }



    //internal void InvalidateResult() {      
     // resultPanel.Invalidate();
    //}


   // internal Pen GetPen() {
    //  if(applicationContext==null)
    //    return null;

    //  Pen result=new Pen(applicationContext.ForegroundColor, 1);
    //  return result;
    //}


    //internal Brush GetBrush() {
    //  if(applicationContext==null)
    //    return null;
//
   //   Brush result=null;
    // int index=brushStyleListBox.SelectedIndex;
    //  if(index==0)
   //     result=new SolidBrush(applicationContext.BackgroundColor);
    //  else {
   //     HatchStyle brushStyle=brushStyleValues[index-1];
    //    result=new HatchBrush(brushStyle,
    //                          applicationContext.ForegroundColor,
    //                          applicationContext.BackgroundColor);
     // }

    //  return result;
   // }

    }
}
