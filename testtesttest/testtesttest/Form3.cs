using System;
using System.Windows.Forms;
using FluentFTP;
using System.Text;
using Mozilla.NUniversalCharDet;
using Ude;

namespace testtesttest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click_1(object sender, EventArgs e)
        {
            string ftpServer = "ftp://ftp.teamgroup.com.tw";  // FTP服务器地址
            string ftpDirectory = "/TEAMQA/"; // FTP服务器上的目录（包括URL编码的文件夹名称）
            string username = "ftp01"; // 请替换为你的FTP用户名
            string password = "Ftp1234"; // 请替换为你的FTP密码

            using (FtpClient client = new FtpClient(ftpServer))
            {
                client.Credentials = new System.Net.NetworkCredential(username, password);

                try
                {
                    client.Connect(); // 连接到FTP服务器

                    client.SetWorkingDirectory(ftpDirectory); // 设置工作目录

                    listBoxFiles.Items.Clear(); // 清空文件列表框

                    // 获取FTP服务器上的文件列表
                    FtpListItem[] items = client.GetListing();

                    foreach (FtpListItem item in items)
                    {
                        string decodedName = DecodeFileName(item.Name);
                        listBoxFiles.Items.Add($"文件名: {decodedName}, 创建时间: {item.Modified}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"连接到FTP服务器时出现错误: {ex.Message}");
                }
                finally
                {
                    client.Disconnect(); // 断开连接
                }
            }
        }

        // 这个函数将文件名解码成中文
        private static string DecodeFileName(string fileName)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(fileName);
            return Encoding.UTF8.GetString(bytes);
        }


        private static bool NotBig5(byte b)
        {
            return b < 0xA4 || b >= 0xF9;
        }

    }
}
