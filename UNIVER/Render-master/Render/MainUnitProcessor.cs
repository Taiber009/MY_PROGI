using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Render
{
    public static class MainUnitProcessor
    {

        public static ModelClass Model;

        public static void ParseModel(string Input)
        {
            Model.Parse(Input);
            Model.TryToDivide(1);
            Model.SendData();
        }

        public static void ParseTexture(string Path)
        {
            Model.SetTexture(new Bitmap(Image.FromFile(Path)));
        }

        public static void ModelDivide(int step)
        {
            Model.TryToDivide(step);
            Model.SendData();
        }
    }
}
