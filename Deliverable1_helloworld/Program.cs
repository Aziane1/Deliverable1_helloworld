namespace Deliverable1_helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution (1): Hello, World!");
            Console.WriteLine(" ");

            string stg = "Hello, World! (2)";
            Console.WriteLine("Solution (2): " + stg);
            Console.WriteLine(" ");

            Console.WriteLine("Enter a user name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("The user name is: " + userName);
            Console.WriteLine(" ");

            Console.WriteLine("Enter the age of the user:  ");
            //Two options for incorporating an integer below are the two options
            //int age = Convert.ToInt32(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("The user's age is: " + age);

        }
    }
}