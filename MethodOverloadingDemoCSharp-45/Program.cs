namespace MethodOverloadingDemoCSharp_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intAdd = Add(2, 2);
            Console.WriteLine(intAdd);

            Greet("Seth");
            Greet("Mack", "McCall", 24);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static void Greet(string firstName)
        {
            Console.WriteLine($"Hello, {firstName}!");
        }

        public static void Greet(string firstName, string lastName)
        {
            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }

        public static void Greet(string firstName, string lastName, int age)
        {
            Console.WriteLine($"Hello, {firstName} {lastName}! You are {age} years old!");
        }

        public static void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}
