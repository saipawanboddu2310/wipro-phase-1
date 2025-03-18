namespace Csharp7and8_Expressionbodydemo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Method
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        // Read-only property
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        // Finalizer (destructor)
        ~Person()
        {
            Console.WriteLine("Person object is being destroyed.");
        }

        public static void add(int a, int b)
        {
            Console.WriteLine($"The sum is {a + b}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new person using expression-bodied constructor
            var person = new Person("John", "Doe");

            // Using expression-bodied method
            Console.WriteLine($"Full Name (method): {person.GetFullName()}");

            // Using expression-bodied property
            Console.WriteLine($"Full Name (property): {person.FullName}");



            // Destructor will run at the end when the program terminates
        }
    }
}
