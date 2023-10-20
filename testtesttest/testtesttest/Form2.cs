using System;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Text;

namespace testtesttest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 在這裡加入初始化程式碼
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string encodedString = "1.%B4%FA%B8%D5/";
            string decodedString = HttpUtility.UrlDecode(encodedString, System.Text.Encoding.UTF8);
            MessageBox.Show(decodedString);
        }

    }
}
