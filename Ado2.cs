using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoDotNet
{
    class Ado2
    {
        public  void Connect()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8R9D1AL\\SQLEXPRESS;Initial Catalog=BizruntimeAsTrainee;Integrated Security=True;User ID=sa;Password=1234");
            con.Open();
            Console.WriteLine("Connection establish");
            SqlCommand cmd = null;
            try
            {
                cmd  =   new SqlCommand("Insert Into EMPLOYEE values(4501,'Nitesh Bansal','Software Developer',45000)", con);
                 cmd.ExecuteNonQuery();

           
                }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                SqlCommand cmd1 = new SqlCommand("Insert Into EMPLOYEE values(7800,'Bal Krishna','Software Developer',45000)", con);
                cmd1.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                }
            }
            Console.WriteLine("Inserted");
        }
        static void Main(string[] args)
        {
           new Ado2().Connect();
            Console.ReadKey();
        }
    }
}
