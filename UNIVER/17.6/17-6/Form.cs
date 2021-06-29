using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _17_6
{
  public partial class Proga : Form
  {
    Logics Tree;
    Graphics Graph;
    bool IsDrawing = false;
    public Proga()
    {
      InitializeComponent();
    }

    private void Vvod_Click(object sender, EventArgs e)
    {
      string Input = Okno.Text;
      Tree = new Logics(Derevo.Width, Derevo.Height);
      Tree.Expr(ref Input, out Tree.pars_Top);
      if (Tree.pars_Err == 0)
      {
        Tree.SetCoords(Tree.pars_Top, 220, 30);
        Info.Text = "Ответ: ";
        Info.Text += bool.Parse(Tree.pars_Top.Value.ToString()) == true ? "True" : "False";
        Draw();
      }
      else
        MessageBox.Show("Ошибка в дереве: " + (Errors)Tree.pars_Err);
    }

    private void Form_Load(object sender, EventArgs e)
    {
      Graph = Derevo.CreateGraphics();
    }

    public void Draw()
    {
      Tree.Draw();
      Graph.DrawImage(Tree.pars_Canvas, 0, 0);
    }

    private void Derevo_MouseDown(object sender, MouseEventArgs e)
    {
      Tree.pars_SelNode = Tree.FindNode(Tree.pars_Top, e.X, e.Y);
      IsDrawing = Tree.pars_SelNode != null;
    }

    private void Derevo_MouseUp(object sender, MouseEventArgs e)
    {
      IsDrawing = false;
    }

    private void Derevo_MouseMove(object sender, MouseEventArgs e)
    {
      if (IsDrawing)
      {
        Tree.Delta(Tree.pars_SelNode, Tree.pars_SelNode.x - e.X, Tree.pars_SelNode.y - e.Y);
        Draw();
      }
    }
  }
}
