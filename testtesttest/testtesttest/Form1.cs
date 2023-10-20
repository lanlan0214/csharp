using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // 引入 System.IO 命名空間
using System.Text;

namespace testtesttest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // 使用非同步方法執行操作
            await Task.Run(() =>
            {
                // 背景執行的操作
                PerformBackgroundTask();
            });
        }


        private void PerformBackgroundTask()
        {
            string folderPath = @"C:\SSD超派"; // 資料夾路徑

            // 使用Directory.Exists檢查資料夾是否存在
            if (Directory.Exists(folderPath))
            {

            }
            else
            {
                try
                {
                    // 資料夾不存在，嘗試創建它
                    Directory.CreateDirectory(folderPath);
                }
                catch (Exception ex)
                {
                    // 處理可能的錯誤
                    MessageBox.Show("無法創建資料夾：" + ex.Message);
                }
            }

            // 背景執行的操作
            // 打開資源管理器
            Thread.Sleep(2000);
            Process.Start("explorer.exe");

            // 等待資源管理器打開
            Thread.Sleep(2000);

            // 在資源管理器中粘貼FTP路徑並按Enter
            string ftpPath = "SSD Series";
            SendKeys.SendWait(ftpPath);
            Thread.Sleep(2000);
            SendKeys.SendWait("{ENTER}");

            // 等待一段時間以確保操作完成
            Thread.Sleep(3000);

            // 選擇所有文件 (CTRL + A)
            SendKeys.SendWait("^(a)");
            Thread.Sleep(2000); // 等待操作完成

            // 複製所選文件 (CTRL + C)
            SendKeys.SendWait("^(c)");
            Thread.Sleep(2000); // 等待操作完成

            // 使用 Process.Start 打開資料夾
            Process.Start("explorer.exe", folderPath);
            Thread.Sleep(2000); // 等待操作完成
            SendKeys.SendWait("^(a)");
            Thread.Sleep(2000); // 等待操作完成
            SendKeys.SendWait("{DELETE}");
            Thread.Sleep(5000); // 等待操作完成
            SendKeys.SendWait("^(v)");
            Thread.Sleep(5000); // 等待操作完成
            MessageBox.Show("超派!");
        }
    }
}
