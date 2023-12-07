using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDataLogic
{
    public class EmployeeDataLogic
    {
        private const string ConnectionString = "Data Source=.;Initial Catalog=Student;Integrated Security=SSPI";

        public static void AddEmployee(string name, string gender, decimal salary)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("AddEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Salary", salary);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
