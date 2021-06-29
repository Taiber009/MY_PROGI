using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SpaceTree
{
    class MyTree
    {
        
        public Node top;          // вершина дерева

        public Node selectNode;   // выделенный узел
        
        public Bitmap bitmap;     // канва для рисования
        const int step = 50;
        const int dh = 1;
        Graphics g;
        Pen myPen;
        SolidBrush myBrush = (SolidBrush)Brushes.White;
        Font myFont;


        public class Node                   // узел
        {
            public object data;
            public Node left;
            public Node right;
            public int x;
            public int y;
            public bool visit;
            public int count;

            public Node(Node left, Node right, object data, int x, int y) // конструктор
            {
                this.left = left;
                this.right = right;
                this.data = data;
                this.x = x;
                this.y = y;
                this.visit = false;
                this.count = 1;
            }
        }
        
        Node q = new Node(null,null,0,0,0);

        void Del(ref Node r)
        { 
            if (r.right != null)
                Del(ref r.right);
            else 
            {
                q.data = r.data;
                q = r; 
                r = r.left;
            }
        }

        public void Delete(int data, ref Node tree)
        {
            if (tree != null)
                if (data < Convert.ToInt32(tree.data))
                    Delete(data, ref tree.left);
                else
                if (data > Convert.ToInt32(tree.data))
                    Delete(data, ref tree.right);
                else 
                {
                    
                    q = tree;
                    if (q.right == null)
                        tree = q.left;
                    else
                        if (q.left == null)
                            tree = q.right;
                        else
                            Del(ref q.left);
                } //Dispose(q);
        }
       
        void Search0(ref Node p, int val, int x, int y) // поиск и вставка
        {
            if (p == null)
            {
               
                p = new Node(null, null, val, x, y);
            }

            else
            {
                p.visit = true;
                if (val < Convert.ToInt32(p.data))
                    Search0(ref p.left, val, p.x - step, p.y + dh * step);
                if (val > Convert.ToInt32(p.data))
                    Search0(ref p.right, val, p.x + step, p.y + dh * step);
                else
                    p.count++;
            }
        }




        public static int Print31(Node top)
        {
            Stack<Node> St = new Stack<Node>();
            int i=0;
            Node p2=null;
            St.Push(top);
            while ((p2!=null)||(St.Count!=0))
            {
                p2=St.Pop();
                i++;
                if (p2.left!=null)
                St.Push(p2.left);
                if (p2.right != null)
                St.Push(p2.right);
                p2 = null;
            }

            return i;
        }

        public static string Print15(Node top)
        {
            Stack<Node> St = new Stack<Node>();
            string s="";
            Node p2 = null;
            St.Push(top);
            while ((p2 != null) || (St.Count != 0))
            {
                p2 = St.Pop();
                s+=p2.data+" ";
                if (p2.left != null)
                    St.Push(p2.left);
                if (p2.right != null)
                    St.Push(p2.right);
                p2 = null;
            }

            return s;
        }


        public void Search(int val)         // поиск и вставка
        {
            Search0(ref top, val, top.x, top.y);
        }
        
        Node FindNodeVal0(Node p, int val)  // поиск по значению
        {
            Node result = null;
            if (Convert.ToInt32(p.data) == val)
            {
                p.visit = true;
                result = p;
            }
            else
            {
                if (p.left != null)
                    result = FindNodeVal0(p.left, val);
                if ((result == null) & (p.right != null))
                    result = FindNodeVal0(p.right, val);
            }
            return result;
        }
        
        public Node FindNodeVal(int val)    // поиск по значению
        {
            if (top != null)
                return FindNodeVal0(top, val);
            else
                return null;
        }
        
        public void DeSelect(Node p)               // снятие признака посещения
        {
            if (p != null)
            {
                //p.visit = false;
                DeSelect(p.left);
                p.visit = false;
                DeSelect(p.right);
            }
        }
        
        public void Delta(Node p, int dx, int dy)  // смещение поддерева
        {
            p.x -= dx; p.y -= dy;
            if (p.left != null)
                Delta(p.left, dx, dy);
            if (p.right != null)
                Delta(p.right, dx, dy);
        }
        
        public Node FindNode(Node p, int x, int y) // поиск по координатам 
        { 
            Node result = null;
            if (p == null)
                return result;
            if (((p.x - x) * (p.x - x) + (p.y - y) * (p.y - y)) < 100)
                result = p;
            else
            {
                result = FindNode(p.left, x, y);
                if (result == null)
                    result = FindNode(p.right, x, y);
            }
            return result;
        }
        
        public void Insert(ref Node t, int data, int x, int y)  // вставка
        {
            if (t == null)
            {
               
                t = new Node(null, null, data, x, y);
            }
            else
                if (data < Convert.ToInt32(t.data))
                    Insert(ref t.left, data, t.x - step, t.y + dh * step);
                else
                    if (data > Convert.ToInt32(t.data))
                        Insert(ref t.right, data, t.x + step, t.y + dh * step);
                    else
                        t.count++;
        }
        
        public MyTree(int VW, int VH)       // конструктор
        {
            top = null;
            bitmap = new Bitmap(VW, VH);
            myFont = new Font("Courier New", 10, FontStyle.Bold); 
        }
        
        void DrawNode(Node p)               // рисование дерева
        {
            int R = 17;
            if (p.left != null)
                g.DrawLine(myPen,p.x, p.y,p.left.x,p.left.y);
            if (p.right != null)
                g.DrawLine(myPen, p.x, p.y, p.right.x, p.right.y);

            if (p.visit)
                myBrush = (SolidBrush)Brushes.Yellow;
            else
                myBrush = (SolidBrush)Brushes.LightYellow;

            g.FillEllipse(myBrush, p.x - R, p.y - R, 2*R, 2*R);
            g.DrawEllipse(myPen, p.x - R, p.y - R, 2*R, 2*R);
            string s = Convert.ToString(p.data) + ":" + Convert.ToString(p.count);
            SizeF size = g.MeasureString(s, myFont);
            g.DrawString(s, myFont, Brushes.Black,
                p.x - size.Width / 2,
                p.y - size.Height / 2);

            if (p.left != null)
                DrawNode(p.left);
            if (p.right != null)
                DrawNode(p.right);
        }
        
        public void Draw()                  // рисование дерева
        {
            using (g = Graphics.FromImage(bitmap))
            {
                Color cl = Color.FromArgb(255, 255, 255);
                g.Clear(cl);
                myPen = Pens.Black;
                if (top != null)
                    DrawNode(top);
            }
        }
        
        public string SetStrSort(Node p)
        {
            string s="";
            if (p == null)
                return s;
            if (p.right != null)
                s += SetStrSort(p.right);
            s += Convert.ToString(p.data) + "\r\n";
            if (p.left != null)
                s += SetStrSort(p.left);
            return s;
        }
    }
}
