using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using MultiTextTools.Classes;

namespace MultiTextTools
{
    public partial class f : Form
    {
        IModule[] modules;//набор модулей
        public f()
        {
            InitializeComponent();
            Reload();
        }
        private void Reload()//обновление списка модулей в списке
        {
            Type[] typelist = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace == "MultiTextTools.Classes").ToArray();
            modules = new IModule[typelist.Length];

            lbModules.Items.Clear();
            for (int i = 0; i < modules.Length; i++)
            {
                modules[i] = Activator.CreateInstance(Type.GetType(typelist[i].FullName)) as IModule;
                lbModules.Items.Add(modules[i].Name());
            }
            lbModules.SelectedIndex = 0;
        }
        private void bGo_Click(object sender, EventArgs e)//запуск
        {

            IModule selectedModule = modules[lbModules.SelectedIndex];
            f.ActiveForm.Text = selectedModule.Name();
            tb2.Text = selectedModule.Answer(tb1.Text);
        }

        private void lbModules_SelectedIndexChanged(object sender, EventArgs e)//смена подсказки при выборе другого модуля
        {
            tbTip.Text = modules[lbModules.SelectedIndex].Tip();
        }

        private void bInsert_Click(object sender, EventArgs e)//перенос текста из второго текстбокса в первый
        {
            tb1.Text = "";
            tb1.Text = tb2.Text;
        }

        private void bReload_Click(object sender, EventArgs e)//отдельная кнопка для обновления Reload()
        {
            Reload();
        }
    }
}
