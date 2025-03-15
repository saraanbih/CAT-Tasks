namespace Employees
{
    public enum SecurityPrivilege
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityPrivilege SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set
            {
                if (value.ToUpper() == "M" || value.ToUpper() == "F")
                    _gender = value.ToUpper();
                else
                    throw new ArgumentException("Gender must be 'M' or 'F'");
            }
        }

        public Employee(int id, string name, SecurityPrivilege securityLevel, decimal salary, DateTime hireDate, string gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender; 
        }

        public override string ToString()
        {
            string formattedSalary = String.Format("{0:C}", Salary); 
            return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {formattedSalary}, Hire Date: {HireDate.ToShortDateString()}, Gender: {Gender}";
        }
    }
}