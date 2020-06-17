using System;

namespace EmployeeView
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee empModel = new Employee();
            IEmployeeView empView = new EmployeeView();

            empModel.FirstName = "David";
            empModel.LastName = "Brown";
            empModel.EmployeeID = 32567;
            empModel.EmployeeSalary = 90000.00M;

            EmployeeController empController = new EmployeeController(empModel, empView);
            empController.DisplayEmploeeInfo();

            Console.ReadLine();
        }
    }
}
