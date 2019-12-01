using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Database
    {
        Connection conn = new Connection();
        public void M1(string query)
        {
            SqlDataReader reader;
            reader = conn.SelectDB(query);
            while (reader.Read())
            {
                Console.ReadLine();
                //Console.WriteLine(String.Format("{0} \t | {1} \t | {2} \t | {3}",
                //    reader[0], reader[1], reader[2], reader[3]));
            }
        }

        public void AirCrewInsert(string query)
        {
            conn.InsertDB(query);
        }
    }
}
