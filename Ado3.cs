using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoDotNet
{
    class Ado3
    {

        public void Connect()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8R9D1AL\\SQLEXPRESS;Initial Catalog=BizruntimeAsTrainee;Integrated Security=True;User ID=sa;Password=1234");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Employee", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            for (int i = 0; i < sdr.FieldCount; i++)
            {
                Console.WriteLine(sdr.GetName(i) + "\t");

            }
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Console.Write(sdr[i] + "\t");
                }
                Console.Write("\n");
            }
            con.Close();
        }
            static void Main(string[] args)
        {

            new Ado3().Connect();
            Console.ReadKey();
        }
    }
}
