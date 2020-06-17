using System;

namespace studentTest
{
    class StudentController
    {
        private Student model;
        private StudentView view;

        public StudentController(Student model, StudentView view)
        {
            this.model = model;
            this.view = view;
        }

        public void setStudentName(String name)
        {
            model.Name = name;
        }

        public String getStudentName()
        {
            return model.Name;
        }

        public void setStudentRollNo(String rollNo)
        {
            model.RollNo = rollNo ;
        }

        public String getStudentRollNo()
        {
            return model.RollNo;
        }

        public void updateView()
        {
            view.printStudentDetails(model.Name, model.RollNo);
        }
    }
}
