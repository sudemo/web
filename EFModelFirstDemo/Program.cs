using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFModelFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            using (var db = new ccf02Entities())
            {
                var res = (from st in db.person_test
                           where st.name == "alice"
                           select st.name).ToString();
               // db.Database.Log = Console.WriteLine;
                var rs = db.person_test.Find(1);
                Console.WriteLine(res);


                Console.WriteLine(rs.name);
            }
            //Console.ReadLine();
            //c
        }
    }
}
