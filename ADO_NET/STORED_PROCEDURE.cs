using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET
{
    public class STORED_PROCEDURE
    {
         string connectionString = "Data Source=SURAJ;Initial Catalog=todo;Integrated Security=True;Encrypt=False";
        public void InsertTask()
        {
            Console.Write("Enter Task : ");
            string Tname=Console.ReadLine();
            string url = "sp_CreateTask";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(url, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Tname", Tname);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("task Inserted successfully....");
            }catch(Exception ex)
            {
                Console.WriteLine(ex); 
            }
            
        }
        public void ReadAllTask()
        {
            try
            {
                string url = "GetAllTasks";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(url, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    Console.WriteLine("Id\tTaskName");
                    while (reader.Read())
                    {
                        Console.WriteLine(Convert.ToInt32(reader["Id"]) + "\t" + reader["Tname"].ToString());
                    }

                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void UpdateTask()
        {
            try
            {
                Console.Write("Enter Task Id to Update: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Enter New Task : ");
                string Tname = Console.ReadLine();
                string url = "UpdateTask";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(url, conn);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Tname", Tname);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    int row=cmd.ExecuteNonQuery();
                    if (row < 0)
                    {
                        Console.WriteLine("Task Not Found...");
                    }
                    else
                    {
                        Console.WriteLine("Task Updated Successfully");
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void DeleteTask()
        {
            Console.Write("Enter Id to delete : ");
            int Id = int.Parse(Console.ReadLine());
            string url = "DeleteTask";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd=new SqlCommand(url, conn);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.CommandType= CommandType.StoredProcedure;
                conn.Open();
                int row=cmd.ExecuteNonQuery();
                if (row < 0)
                {
                    Console.WriteLine("Task Not Found");
                }
                else
                {
                    Console.WriteLine("Task Deleted Successfully");
                }
            }
        }

    }
}
