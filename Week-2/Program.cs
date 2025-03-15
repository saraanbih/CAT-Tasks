using Employees;

namespace Week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Student Class
            Student student = new Student("Sara", 19, 100.9f);
            student.PrintDetails();

            PostGraduate pgStudent = new PostGraduate("Hager", 25, 92.0f, "Data Analysis in Education");
            pgStudent.PrintDetails();
            #endregion

            #region Employee CLass
            Employee emp = new Employee(1, "Shrouk", SecurityPrivilege.Developer, 75000.50m, new DateTime(2020, 5, 15), "F");

            Console.WriteLine(emp.ToString());
            #endregion

            Console.ReadKey();
        }
    }
}