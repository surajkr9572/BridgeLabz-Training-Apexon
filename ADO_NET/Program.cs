using Microsoft.Data.SqlClient;
namespace ADO_NET
{
    internal class Program
    {
        static string connectionString = "Data Source=SURAJ;Initial Catalog=todo;Integrated Security=True;Encrypt=False";
        static void Main(string[] args)
        {
           // InsertTask();
            ReadTask();
        }
        static void InsertTask()
        {
            Console.Write("Enter Task Name : ");
            string tname=Console.ReadLine();
            string url = "INSERT INTO Task VALUES(@tname)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(url, conn);
                cmd.Parameters.AddWithValue("@Tname",tname);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Task Inserted Successfully");
        }
        static void ReadTask()
        {
            string url = "SELECT * FROM TASK";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(url, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    Console.WriteLine("Id\tTname");
                    while (reader.Read())
                    {
                        Console.WriteLine(Convert.ToInt32(reader["Id"])+"\t"+reader["Tname"].ToString());
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
