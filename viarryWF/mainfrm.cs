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
    public partial class mainfrm : Form
    {
        private Form1 form1;
        public mainfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            //this.Hide();//隐藏当前页面
            this.Close();//关闭程序
            form1.Show();//显示上一个页面            
        }
    }
}
