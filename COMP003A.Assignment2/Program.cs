/*AUthor: Victor Flores
 Course: COMP003A
Faculty: Jonathon Cruz
Purpose: A program demonstrating a discount calculator.*/
namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userFname;
            string UserLname;
            int userAge;
            double productPrice;
            bool isStudent;
            

            Console.WriteLine("What is your first name?");
            userFname = Console.ReadLine();
            
            Console.WriteLine("What is your last name?");
            UserLname = Console.ReadLine();
            //these two will read the first and last name of user. 

            Console.WriteLine("What is your age?");
            userAge = int.Parse(Console.ReadLine());
            //This will read user's age

            Console.WriteLine("What is the price of the item you're interested in?");
            productPrice = int.Parse(Console.ReadLine());
            //this will read the price of an said item

            Console.WriteLine("Are you a student? (True/False)");
            isStudent = bool.Parse(Console.ReadLine());
            //will determine if user is student

            //following lines will perform calculations
            int futureAge = userAge + 5;
            bool isSenior = userAge >= 60;
            bool isDiscount = isSenior && futureAge >= 60;
            double isStudent_discount = productPrice * 0.9;
            double isSenior_discount = productPrice * 0.8;


            //following lines will be output
            Console.WriteLine($"\nHello {userFname} {UserLname}!");
            Console.WriteLine($"Your current age is {userAge}.");
            Console.WriteLine($"In 5 years, you will be {futureAge}.");
            Console.WriteLine($"The origanl price of the item is ${productPrice}.");
            Console.WriteLine($"As a student, your discounted price is ${isStudent_discount}.");
            Console.WriteLine($"As a senior citizen, your discounted price would be ${isSenior_discount}.");

        }
    }
}
