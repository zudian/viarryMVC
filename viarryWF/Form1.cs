using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viarryWF
{
    //创建一个应用窗口
    public partial class Form1 : Form
    {
        /// <summary>
        /// 实例化服务端方法
        /// </summary>
        /// 
        serviceRef.Service1Client service = new serviceRef.Service1Client();

        /// <summary>
        /// 创建第二页面
        /// </summary>
        private mainfrm mainfrm;

        public Form1()
        {
            InitializeComponent();
            this.Text = "测试应用";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInputText = this.userInputText.Text;
            string serverReturnContents = service.getUserInput(userInputText);
            this.serverReturnContext.Text = serverReturnContents;
            mainfrm = new mainfrm();
            this.Hide();//隐藏当前页面
            mainfrm.Show();
        }

        private void userInputText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void userInputText_CursorChanged(object sender, EventArgs e)
        {
            string userInputText = this.userInputText.Text;
            this.inputtingContents.Text = userInputText;
        }
    }
}
