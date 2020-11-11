using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            BindingandDisplay2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new ccf02Entities())
            {
                //刷新 dgv1
                this.dataGridView1.Invalidate();
                //var info = db.UserInfo.Where(c => c.Age > 10).OrderBy(c => c.Age);
                //var res = db.person_test.Where(a => a.age == 12).OrderBy(a => a.name);
                var res = db.person_test;
                foreach (var info in res)
                {
                    //db.Entry(info).Collection() ;
                    //richTextBox1.AppendText(info.name.ToString()+"\r\n");
                }
                // Will hit the database
                var blog = db.person_test.Find(3);

                // Will return the same instance without hitting the database

                //db.person_test.Add(new person_test { idperson_test=8,age = 31, name = "generate", sex = "m" });
                //db.person_test.Add(new person_test { idperson_test=9,age = 31, name = "generate", sex = "m" });

                // Will find the new blog even though it does not exist in the database
                //delp.name = "ff";
                //delp.idperson_test = 0;
                //db.person_test.Attach(delp);
                //db.Entry(delp).State = System.Data.Entity.EntityState.Modified;
                //MessageBox.Show(db.Entry(delp).State.ToString());
                //db.Entry(delp).State = System.Data.Entity.EntityState.Deleted;
                //var newBlog = db.person_test.Remove(delp);

                db.SaveChanges();

                // Will find a User which has a string primary key
                //var user = db.person_test.Find("neo");
                //var s = db.person_test.Find(0);
                //this.dataGridView1.Refresh();
                this.person_testTableAdapter.Fill(this.ccf02DataSet.person_test);
            }

            BindingandDisplay();
        }

        private void BindingandDisplay()
        {
            Item[] items = new Item[] { new Item("one"), new Item("two"), new Item("three") };//重新构建一个类

            /*DataGridView默认情况下会显示所绑定对象的属性，如绑定一个List<User>，User的Name、Age、Gender等属性会
             * 作为Column的内容显示出来。对于一个字符串来说，只有一个实例属性Length，因此显示的即为字符串的长度了。
             * 当然，如果有其他属性存在，仍然会作为Column显示出来。*/
            var test = new List<string> { "just", "a", "test" };

            //var buff = new string [] { "ss", "s2", "s3" };
            //System.Reflection.PropertyInfo[] res1 = buff.GetType().GetProperties();
            //var value = res1.GetValue(,null);
            //this.dataGridView2.DataSource = test;//dgv默认查找对象的第一个默认属性，string的唯一的一个属性就是length

            this.dataGridView2.DataSource = (from text in test select new { text }).ToList();
        }
        private void BindingandDisplay2()
        {
            //需要在dgv中手动添加列
            int index = this.dataGridView2.Rows.Add();
            this.dataGridView2.Rows[index].Cells[0].Value = "1";
            this.dataGridView2.Rows[index].Cells[1].Value = "2";
            this.dataGridView2.Rows[index].Cells[2].Value = "监听";

        }

        private void BindingandDisplay3()
        {
            //直接add数组的话会视数组中的每个元素bai为一行，所以出现了都只有第一列的三行

            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell
            textboxcell = new DataGridViewTextBoxCell();
            textboxcell.Value = "aaa";
            row.Cells.Add(textboxcell);


            DataGridViewComboBoxCell comboxcell = new DataGridViewComboBoxCell();
            //comboxcell.Value = "xx";
            row.Cells.Add(comboxcell);
            dataGridView2.Rows.Add(row);
        }



        /// <summary>
        /// 删除某一条数据
        /// </summary>
        /// <param name="id"></param>
        public void Deleted(int id) //添加两个参数entity & table
        {
            using (var entity = new ccf02Entities())
            {
                person_test p = new person_test() { idperson_test = id };

                var model = entity.person_test.FirstOrDefault(w => w.idperson_test == id);
                entity.person_test.Remove(model);
                entity.SaveChanges();
            }

        }

        /// <summary>
        /// 添加实例
        /// </summary>
        /// <param name="student"></param>
      
        public void Insert(person_test p)//可以添加一个entity 参数
        {
            using (var entity = new ccf02Entities())
            {
                entity.person_test.Add(p);
                entity.SaveChanges();

            }
        }


        /// <summary>
        /// 修改实例
        /// </summary>
        /// <param name="model"></param>
        public void Edit(person_test model)
        {
            using (var entity = new ccf02Entities())
            {
                entity.Entry(model).State = EntityState.Modified;
                entity.SaveChanges();
            }

        }


        /// <summary>
        /// 查询实例
        /// </summary>
        /// <returns></returns>
        public void select()
        {
            using (var entity = new ccf02Entities())
            {
                //DataTable dataTable = entity.person_test;
                DbSet dt = entity.person_test;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
            this.dataGridView2.Rows[1].Cells[2].Style.BackColor = Color.Red;
            MessageBox.Show("cellclick");
        }
    }
    class Item
    {
        private string _text;
        public string Text
        {
            get { return _text; }
        }
        public Item(string text)
        {
            this._text = text;
        }
    }
}
