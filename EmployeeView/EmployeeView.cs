using System;

namespace EmployeeView
{
    interface IEmployeeView
    {
        void DisplayEmploeeView(IEmployee emp);
    }
    class EmployeeView : IEmployeeView
    {
        public void DisplayEmploeeView(IEmployee emp)
        {
            Console.WriteLine("Employee");
            Console.WriteLine("*******************************");
            Console.WriteLine("Employee First Name - {0}", emp.FirstName);
            Console.WriteLine("Employee Last Name  - {0}", emp.LastName);
            Console.WriteLine("Employee ID         - {0}", emp.EmployeeID.ToString());
            Console.WriteLine("Employee Salary     - {0}", emp.EmployeeSalary.ToString());
        }
    }
}
