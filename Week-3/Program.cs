namespace Generic_Week
{
    class Program 
    {
        static void Swap<T>(ref T var1,ref T var2)
        {
            T temp;
            temp = var1;
            var1 = var2;
            var2 = temp;
        }
        static int FindGrade(Dictionary<string, int> StInfo, string name) => StInfo.ContainsKey(name) ? StInfo[name] : -1;
        static void CustomerService(Queue<string> CustomerServiceLine)
        {
            while (CustomerServiceLine.Count > 0)
            {
                Console.WriteLine($"Customer {CustomerServiceLine.Dequeue()} is being served");
            }
        }
        static void Main(string[] args)
        {
            #region Generic Swap
            Console.WriteLine("Swap Integres");
            int a = 10, b = 20;
            Console.WriteLine($"Before Swapping: Number 1 = {a} ,Number 2 = {b}");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"After Swapping : Number 1 = {a} ,Number 2 = {b}");
            Console.WriteLine("Swap Strings");
            string str1 = "Happy", str2 = "Ramdan";
            Console.WriteLine($"Before Swapping: String 1 = {str1} ,String 2 = {str2}");
            Swap<string>(ref str1, ref str2);
            Console.WriteLine($"After Swapping : String 1 = {str1} ,String 2 = {str2}");
            #endregion

            Console.WriteLine("********************************************************");

            #region Store Student Info
            Dictionary<string,int> StInfo = new Dictionary<string, int>();
            StInfo.Add("Ali", 20);
            StInfo.Add("Ahmed", 21);
            StInfo.Add("Sara", 22);
            StInfo.Add("Sana", 23);
            StInfo.Add("Saba", 24);
            Console.WriteLine($"Ali's Grade : {FindGrade(StInfo,"Ali")}");
            Console.WriteLine($"Ahmed's Grade : {FindGrade(StInfo, "Ahmed")}");
            Console.WriteLine($"Sara's Grade : {FindGrade(StInfo, "Sara")}");
            #endregion

            Console.WriteLine("********************************************************");

            #region Customer Service Line
            Queue<string> CustomerServiceLine = new Queue<string>();
            CustomerServiceLine.Enqueue("Ali");
            CustomerServiceLine.Enqueue("Ahmed");
            CustomerServiceLine.Enqueue("Sara");
            CustomerServiceLine.Enqueue("Sana");
            CustomerServiceLine.Enqueue("Saba");
            CustomerService(CustomerServiceLine);
            #endregion
            Console.ReadKey();
        }
    }
}