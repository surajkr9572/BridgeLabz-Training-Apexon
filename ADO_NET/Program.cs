using Microsoft.Data.SqlClient;
namespace ADO_NET
{
    internal class Program
    {
        static string connectionString = "Data Source=SURAJ;Initial Catalog=todo;Integrated Security=True;Encrypt=False";
        static void Main(string[] args)
        {
           CreateTask();
           ReadTask();
           UpdateTask();
           DeleteTask();
        }
        static void CreateTask()
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
        static void UpdateTask()
        {
            Console.Write("Enter Task Id to Update: ");
            int Id = int.Parse(Console.ReadLine());
            Console.Write("Enter New Task : ");
            string Tname = Console.ReadLine();

            string url = "UPDATE Task SET Tname=@Tname Where Id=@Id";
            try
            {
                using(SqlConnection  conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(url, conn);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Tname", Tname);
                    conn.Open();
                    int row = cmd.ExecuteNonQuery();
                    if (row < 0)
                    {
                        Console.WriteLine("No Task Found with given Id");
                    }
                    else
                    {
                        Console.WriteLine("Task Updated Successfully");
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex);
            }
        }
        static void DeleteTask()
        {
            Console.Write("Enter Id to delete : ");
            int Id = int.Parse(Console.ReadLine());
            string url = "DELETE FROM Task WHERE Id=@Id";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(url, conn);
                    cmd.Parameters.AddWithValue("Id", Id);
                    conn.Open();
                    int row = cmd.ExecuteNonQuery();
                    if (row < 0)
                    {
                        Console.WriteLine("Task Not Found.....");
                    }
                    else
                    {
                        Console.WriteLine("Task Deleted Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
