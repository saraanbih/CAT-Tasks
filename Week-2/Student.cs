namespace Week_2
{
    public class Student
    {
        public string Name { get; set; }
        public ushort Age { get; set; }
        public float Grade { get; set; }

        public Student(string name, ushort age, float grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public virtual void PrintDetails() => Console.WriteLine($"Name: {Name},Age: {Age} ,Grade: {Grade}");

    }

    public class PostGraduate : Student
    {
        public string ThesisTopic { get; set; }

        public PostGraduate(string name, ushort age, float grade, string thesisTopic)
                    : base(name, age, grade)
        {
            ThesisTopic = thesisTopic;
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}, Thesis Topic: {ThesisTopic}");
        }
    }
}
