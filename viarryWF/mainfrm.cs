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

        serviceRef.Service1Client serviceRef = new serviceRef.Service1Client();
        public mainfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var SQLResult = serviceRef.sqlComman("select * from GUIDE_Parts where partNo < 10");
            Console.WriteLine(SQLResult);
        }
    }
}
