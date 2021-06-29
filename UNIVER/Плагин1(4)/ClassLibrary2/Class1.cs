using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Oop.Tasks.Paint.Interface;

namespace Plug1
{
    [PluginForLoad(true)]
    class Class : IToolPaintPlugin
    {
        private IPaintPluginContext pluginContext = null;
        private ClassLibrary2.UserControl1 optionsControl = null;
        private Cursor cursor = null;
        private Image icon = null;
        private Bitmap bi = null;
        private double mid;

        private IPaintApplicationContext ApplicationContext
        {
            get
            {
                if (pluginContext == null)
                    return null;
                else
                    return pluginContext.ApplicationContext;
            }
        }


        public void AfterCreate(IPaintPluginContext pluginContext)
        {
            this.pluginContext = pluginContext;

            optionsControl = new ClassLibrary2.UserControl1(
                                   ApplicationContext);
            //optionsControl.Save();///
            // bi = (Bitmap)(ApplicationContext.Image.Clone());

            string imageDir = pluginContext.PluginDir;
            if (imageDir != null)
            {
                imageDir += @"\Images\";

                try
                {
                    icon = Image.FromFile(imageDir + "Icon.bmp");
                }
                catch
                {
                    // подавление исключения
                }

                try
                {
                    cursor = new Cursor(imageDir + "Cursor.cur");
                }
                catch
                {
                    // подавление исключения
                }
            }
        }


        public void BeforeDestroy()
        {
            optionsControl.Dispose();
            optionsControl = null;
            if (cursor != null)
                cursor.Dispose();
            if (icon != null)
                icon.Dispose();
        }


        public void Select(bool selection)
        {
            if (selection)
            {
                ApplicationContext.OptionsControl = optionsControl;
                ApplicationContext.Cursor = cursor;

                //optionsControl.Save();///
                //bi = (Bitmap)(ApplicationContext.Image.Clone());
               // Newmid();
            }
            else
            {
                ApplicationContext.OptionsControl = null;
                ApplicationContext.Cursor = null;
            }

        }


        public string Name
        {
            get
            {
                return this.GetType().Name;
            }
        }


        public string CommandName
        {
            get
            {
                return "Контрастность и яркость";
            }
        }

        public void MouseDown(MouseEventArgs me, Keys modifierKeys)
        {

        }


        public void MouseUp(MouseEventArgs me, Keys modifierKeys)
        {
        }


        public void MouseMove(MouseEventArgs me, Keys modifierKeys)
        {
        }


        public void Escape()
        {
        }

        //tmp.G + f > 0 && tmp.B + f > 0
        public void Newmid()
        {
            mid = 0;
            for (int i = 0; i < bi.Height; i++)
                for (int j = 0; j < bi.Width; j++)
                {
                    Color tmp = bi.GetPixel(j, i);
                    mid += (double)(tmp.R) * 0.299 + (double)(tmp.G) * 0.587 + (double)(tmp.B) * 0.114;
                }
            mid /= bi.Height * bi.Width;
        }
        public void Enter()
        {
            Bitmap bitmap = null;
            using (Graphics G = Graphics.FromImage(ApplicationContext.Image))
            {
                bitmap = ApplicationContext.Image;
            }
            int y = optionsControl.Yarkost,
                k = optionsControl.Kontrast;
           // if (f == 0 & s == 0)
          //  {
           //     optionsControl.Save();
           //     bi = (Bitmap)(bitmap.Clone());
           // }
            if (y != 0)
            {
                {
                    for (int i = 0; i < bitmap.Height; i++)
                        for (int j = 0; j < bitmap.Width; j++)
                        {
                            Color tmp = bitmap.GetPixel(j, i);
                            if (tmp.R + y > 0 && tmp.R + y < 255)
                            {
                                tmp = Color.FromArgb(tmp.R + y, tmp.G, tmp.B);
                            }
                            if (tmp.G + y > 0 && tmp.G + y < 255)
                            {
                                tmp = Color.FromArgb(tmp.R, tmp.G + y, tmp.B);
                            }
                            if (tmp.B + y > 0 && tmp.B + y < 255)
                            {
                                tmp = Color.FromArgb(tmp.R, tmp.G, tmp.B + y);
                            }
                            bitmap.SetPixel(j, i, tmp);
                        }
                }
                ApplicationContext.Invalidate();
            }
            if (k != 0)
            {
                using (Graphics G = Graphics.FromImage(ApplicationContext.Image))
                {
                    for (int i = 0; i < bitmap.Height; i++)
                        for (int j = 0; j < bitmap.Width; j++)
                        {
                            Color tmp = bitmap.GetPixel(j, i);
                            byte min = tmp.R;
                            if (tmp.G < min) min = tmp.G;
                            if (tmp.B < min) min = tmp.B;
                            if (tmp.R == min)
                                if (tmp.G + k > min && tmp.G + k < 255 && tmp.B + k > min && tmp.B + k < 255)
                                {
                                    tmp = Color.FromArgb(tmp.R, tmp.G+k, tmp.B+k);
                                }

                            if (tmp.G == min)
                                if (tmp.R + k > min && tmp.R + k < 255 && tmp.B + k > min && tmp.B + k < 255)
                                {
                                    tmp = Color.FromArgb(tmp.R+k, tmp.G, tmp.B+k);
                                }

                            if (tmp.B == min)
                                if (tmp.R + k > min && tmp.R + k < 255 && tmp.G + k > min && tmp.G + k < 255)
                                {
                                    tmp = Color.FromArgb(tmp.R+k, tmp.G+k, tmp.B);
                                }
                            bitmap.SetPixel(j, i, tmp);
                        }
                }
                ApplicationContext.Invalidate();
            }
        }


        public void ColorChange()
        {
            //optionsControl.InvalidateResult();
        }


        public void ImageChange()
        {
            //optionsControl.InvalidateResult();
        }


        public string ToolName
        {
            get
            {
                return "Контрастность и Яркость";
            }
        }


        public Image Icon
        {
            get
            {
                return icon;
            }
        }
    }
}
