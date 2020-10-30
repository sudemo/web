using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCoreDemo4SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var builder = new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                Database = "ccf02",
                UserID = "root",
                Password = "root",
                //SslMode = MySqlSslMode.Required,
            };

            using (var conn = new MySqlConnection(builder.ConnectionString))
            {
                Console.WriteLine("Opening connection");
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = "DROP TABLE IF EXISTS inventory;";
                    command.ExecuteNonQueryAsync();
                    Console.WriteLine("Finished dropping table (if existed)");

                    command.CommandText = "CREATE TABLE inventory (id serial PRIMARY KEY, name VARCHAR(50), quantity INTEGER);";
                    command.ExecuteNonQueryAsync();
                    Console.WriteLine("Finished creating table");

                    command.CommandText = @"INSERT INTO inventory (name, quantity) VALUES (@name1, @quantity1),
                        (@name2, @quantity2), (@name3, @quantity3);";
                    command.Parameters.AddWithValue("@name1", "banana");
                    command.Parameters.AddWithValue("@quantity1", 150);
                    command.Parameters.AddWithValue("@name2", "orange");
                    command.Parameters.AddWithValue("@quantity2", 154);
                    command.Parameters.AddWithValue("@name3", "apple");
                    command.Parameters.AddWithValue("@quantity3", 100);

                    //int rowCount =  command.ExecuteNonQueryAsync();
                    ////Console.WriteLine(String.Format("Number of rows inserted={0}", rowCount));
                }

                // connection will be closed by the 'using' block
                Console.WriteLine("Closing connection");
            }

            Console.WriteLine("Press RETURN to exit");
            Console.ReadLine();






        }

        private void button2_Click(object sender, EventArgs e)
        {
            initsql2();

        }

        private void initsql()
        {
            string connString = "server=localhost;database=ccf02;uid=root;pwd=root";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("连接成功！", "测试结果");
                // MySqlDataReader reader = null;

                MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", conn);



                try

                {

                    using (var command = conn.CreateCommand())
                    {
                        command.CommandText = "SELECT * FROM person_test;";

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                if (richTextBox1.InvokeRequired)
                                {
                                    this.Invoke(new Action(() =>
                                    {
                                        richTextBox1.Text = reader.GetString(0);
                                    }));
                                }
                                richTextBox1.AppendText(reader[1].ToString() + "\r\n");
                                //Console.WriteLine(string.Format(
                                //    "Reading from table=({0}, {1}, {2})",
                                //    reader.GetInt32(0),
                                //    reader.GetString(1),
                                //    reader.GetInt32(2)));
                            }
                        }
                    }
                    //while (reader.Read())

                    //{

                    //    //databaseList.Items.Add(reader.GetString(0));

                    //}

                }

                catch (MySqlException ex)

                {

                    MessageBox.Show("Failed to populate database list: " + ex.Message);

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void initsql2()
        {
            //数据库连接串
            //string connStr = "Data Source=.;Initial Catalog=test;User ID=sa;Password=root";
            string connStr = "server=localhost;database=ccf02;uid=root;pwd=root";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
               
                conn.Open();
                MessageBox.Show("连接成功！", "测试结果");
                MySqlDataReader reader = null;
                
                MySqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandText = "SELECT * FROM person_test";
                MySqlDataAdapter adap1 = new MySqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                adap1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0].DefaultView;

                //MySqlCommand cmd2 = conn.CreateCommand();
                //cmd2.CommandText = "SELECT * FROM person_test";
                //MySqlDataAdapter adap2 = new MySqlDataAdapter(cmd2);
                //DataSet ds2 = new DataSet();
                //adap2.Fill(ds2);
                //dataGridView1.DataSource = ds2.Tables[0].DefaultView;


                //MySqlCommand cmdstr = new MySqlCommand("SHOW DATABASES", conn);




                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询错误！" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    //关闭数据库连接
                    conn.Close();
                }

            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
