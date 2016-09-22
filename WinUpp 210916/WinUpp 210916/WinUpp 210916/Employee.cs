using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUpp_210916
{
    class Employee
    {
        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }

        public string EmployeeTel { get; set; }

        public string EmployeeTitle { get; set; }

        public string EmployeeSalary { get; set; }

        public override string ToString()

        {
            return string.Format("{0} {1} {2} - Tel.Number: {3}. Salary: {4}",EmployeeTitle, EmployeeFirstName, EmployeeLastName, EmployeeTel, EmployeeSalary);

        }

        public Employee()
        {
            EmployeeFirstName = string.Empty;
            EmployeeLastName = string.Empty;
            EmployeeTel = string.Empty;
            EmployeeTitle = string.Empty;
            EmployeeSalary = string.Empty;

        }

    }
}
