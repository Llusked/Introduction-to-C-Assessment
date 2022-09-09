namespace Greetings
{
    class Program
    {
        static void Main()
        {
            Person john = new Person();
            Doctor drJohn = new Doctor();

            string name = Console.ReadLine();
            string phone = Console.ReadLine();
            string email = Console.ReadLine();

            john.SayGreeting();

            Console.WriteLine(name);
            Console.WriteLine("Phone Number: " + phone);
            Console.WriteLine("Email: " + email);

            string docName = Console.ReadLine();
            string Salary = Console.ReadLine();

            drJohn.SayGreeting();

            Console.WriteLine(docName);
            Console.WriteLine("$" + Salary);


        }
    }
}