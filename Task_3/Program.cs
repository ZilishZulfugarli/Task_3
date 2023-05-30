namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher("Niyazi"  , "Babayev" , 20);

            Console.WriteLine("Teacher:");

            Console.WriteLine(t.Name);
            Console.WriteLine(t.Surname);
            Console.WriteLine(t.Age);

            t.Explain();
            Console.WriteLine("");

            Console.WriteLine("Student:");

            Student s = new Student("Zilish",  "Zulfugarli" , 21);
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Surname);
            Console.WriteLine(s.Age);

            s.Learn();



        }
    }
}