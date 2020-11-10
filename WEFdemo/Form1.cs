using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEFdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“ccf02DataSet.capsules”中。您可以根据需要移动或删除它。
             //this.capsulesTableAdapter.Fill(this.ccf02DataSet.capsules);
            // TODO: 这行代码将数据加载到表“ccf02DataSet.person_test”中。您可以根据需要移动或删除它。
            this.person_testTableAdapter.Fill(this.ccf02DataSet.person_test);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new ccf02Entities())
            {
                //var info = db.UserInfo.Where(c => c.Age > 10).OrderBy(c => c.Age);
                var res = db.person_test.Where(a => a.age == 12).OrderBy(a => a.name);
                foreach (var info in res)
                {
                    richTextBox1.AppendText(info.name.ToString()+"\r\n");
                }
            }
        }
    }
}
