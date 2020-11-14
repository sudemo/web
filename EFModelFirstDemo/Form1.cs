using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFModelFirstDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“ccf02DataSet1.person_test”中。您可以根据需要移动或删除它。
            this.person_testTableAdapter.Fill(this.ccf02DataSet1.person_test);
            // TODO: 这行代码将数据加载到表“ccf02DataSet.person_test”中。您可以根据需要移动或删除它。
            //Authentication to host '127.0.0.1' for user 'root' using method 'caching_sha2_password' failed with message: Access denied for user 'root'@'localhost'(using password: NO)”
            //yishang zifuchuan wenti

            this.person_testTableAdapter1.Fill(this.ccf02DataSet.person_test);



        }

        private void persontestBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.person_testTableAdapter1.Fill(this.ccf02DataSet.person_test);

        }
    }
}
