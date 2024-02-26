namespace GA_Nested_If_Salvador_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.Write("Are you a student (yes/no): ");
                string studentStatus = Console.ReadLine();
                if (studentStatus.ToLower() == "yes")
                {
                    Console.Write("Enter your GPA (0.0-4.0): ");
                    double gpa = double.Parse(Console.ReadLine());

                    if (gpa >= 3.0)
                    {
                        Console.WriteLine("Congratulations! You are an adult with a good GPA.");
                    }
                    else
                    {
                        Console.WriteLine("You are an adult student, but your GPA needs improvement.");
                    }
                }
                else
                {
                    Console.WriteLine("You are an adult, but not a student.");
                }
            }
            else
            {
                Console.WriteLine("You are not an adult.");
            }
        }
    }
}
