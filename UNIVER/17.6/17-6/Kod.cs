using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace _17_6
{
    public enum Operations
    {
        AND = 1,
        OR = 2,
    }

    public enum Errors
    {
        NotEnoughBracketException = 9,
        NotEnoughSummandsException = 6,
        NotEnoughElementsException = 5,
        WaitingForExpressionException = 4
    }

    public class Logics
    {
        public byte pars_Err;
        public MyNode pars_Top;
        public MyNode pars_SelNode;

        public Bitmap pars_Canvas;
        Graphics _Graph;
        Pen _Pen;
        SolidBrush _Brush = (SolidBrush)Brushes.White;
        Font _Font;

        public abstract class MyNode
        {
            public abstract object DoOperation();
            public int x;
            public int y;
            protected object value;
            public object Value
            {
                get
                {
                    return DoOperation();
                }
            }
        }

        public class ValueNode : MyNode
        {
            public ValueNode(bool Data)
            {
                value = Data;
            }
            public override object DoOperation()
            {
                return value;
            }
        }

        public class Operation : MyNode
        {
            public Operations opnode_Operation;
            public MyNode opnode_Left;
            public MyNode opnode_Right;

            public Operation(Operations Operation, MyNode Left, MyNode Right)
            {
                opnode_Left = Left;
                opnode_Operation = Operation;
                opnode_Right = Right;
            }

            public override object DoOperation()
            {
                bool Left = bool.Parse(opnode_Left.DoOperation().ToString());
                bool Right = bool.Parse(opnode_Right.DoOperation().ToString());

                switch (opnode_Operation)
                {
                    case Operations.OR:
                        value = Left | Right;
                        return value;
                    case Operations.AND:
                        value = Left & Right;
                        return value;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public Logics(int Width, int Height)
        {
            pars_Top = null;
            pars_Canvas = new Bitmap(Width, Height);
            _Font = new Font("Courier New", 10, FontStyle.Bold);
            pars_Err = 0;
        }

        bool Test(char Input, params char[] Letters)
        {
            return Array.IndexOf(Letters, Input) >= 0;
        }

        string TakeElements(ref string Input, byte Number)
        {
            string result = Input.Substring(0, Number);
            Input = Input.Substring(Number);
            Input = Input.Trim();
            return result;
        }

        void SetValue(ref string Input, out bool Letter)
        {
            Input = Input.Trim();
            Letter = true;
            string Output = "";
            if ((Input != "") && Test(Input[0], 't', 'T', 'F', 'f'))
            {
                Output += TakeElements(ref Input, 1);
            }
            switch (Output)
            {
                case "T":
                case "t":
                    Letter = true;
                    break;
                case "F":
                case "f":
                    Letter = false;
                    break;
            }
            Input.Trim();
        }

        void Fact(ref string Input, out MyNode Node)
        {
            Node = null;
            Input = Input.Trim();

            if (Input.Length != 0)
            {
                if (Test(Input[0], 't', 'T', 'F', 'f'))
                {
                    bool Letter;
                    SetValue(ref Input, out Letter);
                    if (pars_Err != 0)
                        return;
                    Node = new ValueNode(Letter);
                }
                else
                    if (Input[0] == '(')
                    {
                        TakeElements(ref Input, 1);
                        Expr(ref Input, out Node);
                        if (pars_Err != 0)
                            return;
                        Input = Input.Trim();
                        if ((Input.Length > 0) && (Input[0] != ')'))
                        {
                            pars_Err = 9;
                            return;
                        }
                        TakeElements(ref Input, 1);
                    }
                    else
                        pars_Err = 6;
            }
            else
                pars_Err = 6;
        }

        public void Expr(ref string Input, out MyNode Node)
        {
            Input = Input.Trim();
            Node = null;
            if (Input.Length != 0)
            {
                And(ref Input, out Node);
                if (pars_Err != 0)
                    return;
                Input = Input.Trim();

                while ((Input.Length > 0) && (Input[0] == '|'))
                {
                    TakeElements(ref Input, 1);
                    if (Input.Length == 0)
                    {
                        pars_Err = 0;
                        return;
                    }
                    MyNode SecondNode;
                    Or(ref Input, out SecondNode);
                    if (pars_Err != 0)
                        return;
                    MyNode FirstNode = Node;

                    Operations Op = Operations.OR;
                    Node = new Operation(Op, FirstNode, SecondNode);
                }
            }
        }

        void And(ref string Input, out MyNode Node)
        {
            Input = Input.Trim();
            Node = null;
            if (Input.Length != 0)
            {
                Fact(ref Input, out Node);
                if (pars_Err != 0)
                    return;
                while ((Input.Length != 0) && (Input[0] == '&'))
                {
                    TakeElements(ref Input, 1);
                    if (Input.Length == 0)
                    {
                        pars_Err = 6; //Нужен множитель
                        return;
                    }
                    MyNode SecondNode;
                    Fact(ref Input, out SecondNode);
                    if (pars_Err != 0)
                        return;
                    MyNode FirstNode = Node;
                    Operations Op = Operations.AND;
                    Node = new Operation(Op, FirstNode, SecondNode);
                }
            }
            else
                pars_Err = 5;
        }

        void Or(ref string Input, out MyNode Node)
        {
            Node = null;
            Input = Input.Trim();
            string Sign;
            if (Input.Length != 0)
            {
                Fact(ref Input, out Node);
                while ((Input.Length != 0) && (Input[0] == '|'))
                {
                    Sign = TakeElements(ref Input, 1);
                    if (Input.Length == 0)
                    {
                        pars_Err = 5;
                        return;
                    }
                    MyNode SecondNode;
                    And(ref Input, out SecondNode);
                }
            }
            else
                pars_Err = 4;
        }

        public void SetCoords(MyNode Node, int x, int y)
        {
            Node.x = x;
            Node.y = y;
            if ((Node is Operation) && ((Node as Operation).opnode_Left != null))
                SetCoords((Node as Operation).opnode_Left, x - 50, y + 50);
            if ((Node is Operation) && ((Node as Operation).opnode_Right != null))
                SetCoords((Node as Operation).opnode_Right, x + 50, y + 50);
        }

        public void Draw()
        {
            _Graph = Graphics.FromImage(pars_Canvas);
            Color _Col = Color.FromArgb(255, 255, 255);
            _Graph.Clear(_Col);
            _Pen = Pens.Black;
            if (pars_Top != null)
                DrawNode(pars_Top);
        }

        void DrawNode(MyNode Node)
        {
            int R = 17;
            if ((Node is Operation) && ((Node as Operation).opnode_Left != null))
                _Graph.DrawLine(_Pen, Node.x, Node.y, (Node as Operation).opnode_Left.x, (Node as Operation).opnode_Left.y);
            if ((Node is Operation) && ((Node as Operation).opnode_Right != null))
                _Graph.DrawLine(_Pen, Node.x, Node.y, (Node as Operation).opnode_Right.x, (Node as Operation).opnode_Right.y);

            _Brush = (SolidBrush)Brushes.LightYellow;
            _Graph.FillEllipse(_Brush, Node.x - R, Node.y - R, 2 * R, 2 * R);
            _Graph.DrawEllipse(_Pen, Node.x - R, Node.y - R, 2 * R, 2 * R);

            string Data = "";
            if (Node is Operation)
                switch ((Node as Operation).opnode_Operation)
                {
                    case Operations.OR:
                        Data = "|";
                        break;
                    case Operations.AND:
                        Data = "&";
                        break;
                }
            else
                Data = Node.Value.ToString();

            SizeF size = _Graph.MeasureString(Data[0].ToString(), _Font);
            _Graph.DrawString(Data[0].ToString(), _Font, Brushes.Black, Node.x - size.Width / 2, Node.y - size.Height / 2);
            if ((Node is Operation) && ((Node as Operation).opnode_Left != null))
                DrawNode((Node as Operation).opnode_Left);
            if ((Node is Operation) && ((Node as Operation).opnode_Right != null))
                DrawNode((Node as Operation).opnode_Right);
        }


        public MyNode FindNode(MyNode Node, int x, int y)
        {
            MyNode result = null;
            if (Node == null)
                return result;
            if (((Node.x - x) * (Node.x - x) + (Node.y - y) * (Node.y - y)) < 100)
                result = Node;
            else
            {
                if ((Node is Operation) && ((Node as Operation).opnode_Left != null))
                    result = FindNode((Node as Operation).opnode_Left, x, y);
                if ((result == null) && (Node is Operation) && ((Node as Operation).opnode_Right != null))
                    result = FindNode((Node as Operation).opnode_Right, x, y);
            }
            return result;
        }

        public void Delta(MyNode Node, int dx, int dy)  // смещение поддерева
        {
            Node.x -= dx; Node.y -= dy;
            if ((Node is Operation) && ((Node as Operation).opnode_Left != null))
                Delta((Node as Operation).opnode_Left, dx, dy);
            if ((Node is Operation) && ((Node as Operation).opnode_Right != null))
                Delta((Node as Operation).opnode_Right, dx, dy);
        }

    }
}
