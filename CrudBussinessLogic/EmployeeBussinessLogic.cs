using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudBussinessLogic
{
    public class EmployeeBussinessLogic
    {
        public static bool AddEmployee(string name, string gender, decimal salary)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender))
            {
                throw new ArgumentException("Name and gender cannot be empty.");
            }
            return true;
        }
    }
}
