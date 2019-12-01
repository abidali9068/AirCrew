using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Connection
    {
        string connectionString = "Data Source=DESKTOP-O67J6VF;Initial Catalog=AviationManagementSystem;Integrated Security=True";
        SqlConnection conn;
        public SqlConnection ConnectionDB()
        {
            conn = new SqlConnection(connectionString);
            return conn;
                
        }

        public SqlDataReader SelectDB(string query)
        {
            try
            {
                ConnectionDB().Open();
                SqlCommand command = new SqlCommand(query, conn);
                //             SqlCommand myCommand = new SqlCommand(
                //"SELECT * FROM table WHERE Column = @Param2", myConnection);
                //             myCommand.Parameters.Add(myParam2);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("FirstColumn\tSecond Column\t\tThird Column\t\tForth Column\t");
                    return reader;
                    //while (reader.Read())
                    //{
                    //    //Console.WriteLine(String.Format("{0} \t | {1} \t | {2} \t | {3}",
                    //    //    reader[0], reader[1], reader[2], reader[3]));
                    //}
                }
                
                Console.WriteLine("Data displayed! Now press enter to move to the next section!");
                Console.Clear();

                ConnectionDB().Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return null;
            
        }

        public void InsertDB(string query)
        {
            ConnectionDB().Open();
            SqlCommand command = new SqlCommand(query, conn);
          
            command.ExecuteNonQuery();
        }
        
        public void DeleteDB()
        {

        }
    }
}
