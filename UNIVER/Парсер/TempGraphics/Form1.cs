using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TempGraphics
{
  public partial class MainForm : Form
  {
    Kod Mdl;
    Graphics Canvas;
    MouseEventArgs e0;
    bool Drawing;
    public MainForm()
    {
      InitializeComponent();
      Canvas = _ctrlCanvas.CreateGraphics();
      MouseWheel += new MouseEventHandler(_ctrlCanvas_MouseWheel);
    }
    private void TakeObject()
    {
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
        using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
         Mdl.Parse(sr.ReadToEnd());
    }

    private void _ctrlBaton_Click(object sender, EventArgs e)
    {
      Mdl = new Kod();
      TakeObject();
      Mdl.Canv = new Bitmap(_ctrlCanvas.ClientRectangle.Width, _ctrlCanvas.ClientRectangle.Height);
      Mdl.I2 = _ctrlCanvas.Width;
      Mdl.J2 = _ctrlCanvas.Height;
      DrawImg();
    }
    private void DrawImg()
    {
      Mdl.Draw();
      Canvas.DrawImage(Mdl.Canv, _ctrlCanvas.ClientRectangle);
    }
    private void _ctrlCanvas_MouseWheel(object sender, MouseEventArgs e)
    {
      if (Mdl != null)
      {
        Mdl.ChangeWindowXY(e.X,e.Y, e.Delta);
        DrawImg();
      }
    }

    private void _ctrlCanvas_MouseDown(object sender, MouseEventArgs e)
    {
      Drawing = true;
      e0 = e;
    }

    private void _ctrlCanvas_MouseMove(object sender, MouseEventArgs e)
    {
      if (Mdl != null && Drawing)
      {
        if (e.Button == MouseButtons.Left)
        {
          double x = e.X - ClientRectangle.Width / 2;
          double y = e.Y - ClientRectangle.Height / 2;
          Mdl.SetAngle(x, y);
        }
        else
        {
          Mdl.SetDelta(e0, e);
          e0 = e;
        }
        DrawImg();
      }
    }

    private void _ctrlCanvas_MouseUp(object sender, MouseEventArgs e)
    {
      Drawing = false;
    }

  }
}
