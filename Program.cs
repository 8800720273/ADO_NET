using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoDotNet
{
    class Program
    {

        static void Main(string[] args)
        {
            SqlConnection con;
            con = new SqlConnection("Data Source=DESKTOP-8R9D1AL\\SQLEXPRESS;Initial Catalog=BizruntimeAsTrainee;Integrated Security=True;User Id=sd;Password=1234");
            con.Open();
            Console.Write("Connected");
            con.Close();
            Console.ReadKey();

        }
    }
}
