using System;
using System.Data.SqlClient;

namespace AdoDotNet
{
    class Ado1
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(Ado1));

        public static void Create()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-8R9D1AL\\SQLEXPRESS;Initial Catalog=BizruntimeAsTrainee;Integrated Security=True;User ID=sa;Password=1234");
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("CREATE TABLE EMPLOYEE(E_ID int,E_NAME varchar(50),DESIGNATON varchar(50),SALARY int)", con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created");
            }
            catch (Exception e)
            {

                log.Info(e.Message);
                Console.ReadKey();
            }
            finally
            { 
              if(con != null)
                {
                    con.Close();
                }

            }
        }
        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            Create();
        }

    }
}
