using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiliBiliVideoDownloader
    //声明名称空间
{
    public partial class Form1 : Form //交互式WinForm界面

    {
        string folderPath = null;  //声明变量,均为路径
        string file;
        public Form1()
        {
            InitializeComponent();
        }

        public object LoadingText { get; private set; }//初始化LoadingTet

        public void dirbutton1_Click(object sender, EventArgs e) //定义事件,选择文件夹作为命令行工具的保存路径
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件夹";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = dialog.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)//依然如此,选择文件
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择cookies.sqlite文件";
            dialog.Filter = "cookies.sqlite文件(cookies.sqlite)|cookies.sqlite";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = dialog.FileName;
            }
        }

        public void button2_Click(object sender, EventArgs e)//这里就是调用cmd,是普通下载
        {
            string cddir = "cd " + System.IO.Directory.GetCurrentDirectory();//返回工作路径
            string dl = "you " + textBox1.Text + " " + "-o" + " " + folderPath;
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = false;
            p.Start();

            p.StandardInput.WriteLine(cddir + "&" + dl);
            p.StandardInput.AutoFlush = true;
            string strOutput = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();

        }

        private void button3_Click(object sender, EventArgs e)//包含cookies.sqlite,会员下载
        {
            string dl = "you " + textBox1.Text + " " + "-o" + " " + folderPath + " " + "--cookies" + " " + file;
            string cddir = "cd " + System.IO.Directory.GetCurrentDirectory();
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = false;
            p.Start();

            p.StandardInput.WriteLine(cddir + "&" + dl);
            p.StandardInput.AutoFlush = true;
            string strOutput = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();
        }
    }
}
