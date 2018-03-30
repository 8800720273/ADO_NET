using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoDotNet
{
    class Ado4
    {
        public void Connect()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8R9D1AL\\SQLEXPRESS;Initial Catalog=BizruntimeAsTrainee;Integrated Security=True;User ID=sa;Password=1234");
            try
            {
                con.Open();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE EMPLOYEE set E_Name = 'yashwant' where E_Name= 'Nitesh Bansal'", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        
        }
        static void Main(string[] args)
        {
            new Ado4().Connect();
            Console.ReadKey();
        }
    }
}
