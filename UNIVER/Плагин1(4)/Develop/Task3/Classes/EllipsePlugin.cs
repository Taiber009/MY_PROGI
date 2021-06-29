using System;
using System.Drawing;
using System.Windows.Forms;
using Oop.Tasks.Paint.Interface;

namespace Oop.Tasks.Paint.Plugins
{
    [PluginForLoad(true)]
    public class PaintEllipsePlugin :
                 IToolPaintPlugin
    {
        private IPaintPluginContext pluginContext = null;
        private EllipsePluginOptionsControl optionsControl = null;


        private Image icon = null;
        private Cursor cursor = null;

        private Image img;

        private MouseEventArgs m0 = null;
        private bool flag = false;
        private IPaintApplicationContext ApplicationContext
        {
            get
            {
                if (pluginContext == null)
                    return null;
                else return pluginContext.ApplicationContext;
            }

        }
        //Реализация интерфейса после выбора контрола
        public void AfterCreate(IPaintPluginContext pluginContext)
        {
            this.pluginContext = pluginContext;

            optionsControl = new EllipsePluginOptionsControl(ApplicationContext);
            string imageDir = pluginContext.PluginDir;
            if (imageDir != null)
            {
                imageDir += @"\Images\";

                try
                {
                    icon = Image.FromFile(imageDir + "Icon.bmp");
                }
                catch { }

                try
                {
                    cursor = new Cursor(imageDir + "Cursor.cur");
                }
                catch { }
            }
        }
        //Перед переключением на другой контрол
        public void BeforeDestroy()
        {
            optionsControl.Dispose();
            optionsControl = null;
            if (icon != null)
                icon.Dispose();
            if (cursor != null)
                cursor.Dispose();
        }
        //Выбор контрола этого плагина
        public void Select(bool selection)
        {
            if (selection)
            {
                ApplicationContext.OptionsControl = optionsControl;
                ApplicationContext.Cursor = cursor;
            }
            else
            {
                ApplicationContext.OptionsControl = null;
                ApplicationContext.Cursor = null;
            }
        }
        //Возвращает название контрола
        public string Name { get { return this.GetType().Name; } }
        //Название метода
        public string CommandName
        {
            get { return "Нарисовать эллипс"; }
        }
        //При нажатии мыши
        public void MouseDown(MouseEventArgs me, Keys modifierKeys)
        {
            m0 = me;
            flag = true;
            if (img != null)
                img.Dispose();
            img = (Image)ApplicationContext.Image.Clone();

        }
        //При поднятии мыши
        public void MouseUp(MouseEventArgs me, Keys modifierKeys)
        {

            flag = false;
        }
        //При движении мыши
        public void MouseMove(MouseEventArgs me, Keys modifierKeys)
        {
            if (flag)
            {
                Graphics graphics = Graphics.FromImage(ApplicationContext.Image);
                Pen pen = optionsControl.GetPen();
                Brush brush = optionsControl.GetBrush();

                graphics.DrawImage(img, 0, 0);

                int height = Math.Abs(m0.Y - me.Y);
                int width = Math.Abs(m0.X - me.X);
                
                int x, y;
                    if (m0.X < me.X)
                    {
                        x = m0.X;
                    }
                    else
                        x = me.X;
                    if (m0.Y < me.Y)
                    {
                        y = m0.Y;
                    }
                    else
                        y = me.Y;
                    //Для зажатого шифта рисуем круг
                if (modifierKeys == Keys.Shift)
                {
                    if(height > width)
                    {
                        if (m0.Y > me.Y)
                        {
                            y = m0.Y - width;
                        }
                        height = width;
                    }
                    if (width > height)
                    {
                        if (m0.X > me.X)
                        {
                            x = m0.X - height;
                        }
                        width = height;
                    }
                }
                switch (optionsControl.GetEn()) {
                    case 0: graphics.DrawEllipse(pen, x, y, width, height); break;
                    case 1: graphics.FillEllipse(brush, x, y, width, height);
                            graphics.DrawEllipse(pen, x, y, width, height); break;
                    case 2: graphics.FillEllipse(brush, x, y, width, height); break;
            }

                pen.Dispose();
                brush.Dispose();

                ApplicationContext.Invalidate();
            }
        }

        //Пустая реализация
        public void Escape() { }

        //Пустая реализация
        public void Enter() { }

        //Смена цвета
        public void ColorChange()
        {
            optionsControl.InvalidateResult();
        }
        //Смена рисунка
        public void ImageChange()
        {
            optionsControl.InvalidateResult();
        }
        //Название инструмента в нижней полосе пеинта
        public string ToolName
        {
            get { return "Эллипс."; }
        }
        //Иконка инструмента
        public Image Icon
        {
            get { return icon; }
        }
    }
}

