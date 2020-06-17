using System;

namespace EmployeeView
{
    interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int EmployeeID { get; set; }
        decimal EmployeeSalary { get; set; }

        //string Name { get; set; }
        //int Score { get; set; }
        //string Grade { get; set; }
    }

    class Employee : IEmployee
    {
        string _fname;
        string _lname;
        int _employeeId;
        Decimal _empSalary;

        public String FirstName
        {
            get { return _fname; }
            set { _fname = value; }
        }

        public String LastName
        {
            get { return _lname; }
            set { _lname = value; }
        }

        public int EmployeeID
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        public decimal EmployeeSalary
        {
            get { return _empSalary; }
            set { _empSalary = value; }
        }
    }
}
