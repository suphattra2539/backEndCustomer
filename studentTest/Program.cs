using System;

namespace studentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Student model = retriveStudentFromDatabase();// Data Set Value

            StudentView view = new StudentView(); // 

            StudentController controller = new StudentController(model, view);

            controller.updateView();

            controller.setStudentName("Vikram Sharma");

            controller.updateView();
        }
        private static Student retriveStudentFromDatabase()
        {
            
            Student student = new Student()
            { 
                Name = "Lokesh Sharma" , 
                RollNo = "15UCS157" 
            };
            return student;
            
        }

    }
}
