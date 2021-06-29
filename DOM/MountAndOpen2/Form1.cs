using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Automation;
using System.IO;
using System.Runtime.InteropServices;

namespace MountAndOpen2
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool DefineDosDevice(int flags, string DeviceName, string Name);
        public Form1()
        {
            var isoPath = @"T:\Документы.vhd";
            while (!File.Exists(isoPath))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Файл образа жесткого диска (*.vhd)|*.vhd";
                ofd.ShowDialog();
                isoPath = ofd.FileName;
            }

            using (var ps = PowerShell.Create())
            {
                //ps.AddCommand("Mount-DiskImage").AddParameter("ImagePath", path);
                //ps.Invoke();
                //var command = ps.AddCommand("Mount-DiskImage");
                //command.AddParameter("ImagePath", isoPath);
                //command.AddParameter("PassThru");
                //foreach (PSObject psObject in command.Invoke())
                //{
                //    var path = psObject.Members["DevicePath"].Value;
                //}
                //InitializeComponent();
                if (!DefineDosDevice(0,"V:",isoPath))
                    throw new Win32Exception();
            }
        }
    }
}
