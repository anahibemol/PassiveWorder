// See https://aka.ms/new-console-template for more information
namespace PassiveWorder
{
    class Passworder {         
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the password");
            
            string? Password = "";
            
            Console.WriteLine(Password);
            Password = Console.ReadLine();

            if(Password == "1234")
            {
                Console.WriteLine("Permission Granted");
            }
            else
            {
                Console.WriteLine("Wrong Password");
            }
        }
    }
}