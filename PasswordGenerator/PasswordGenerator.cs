using System;

namespace PasswordGenerator
{
   public class GeneratePassword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Name!");
            string userName=Console.ReadLine();
            Console.WriteLine("Password : Should have Capital letter, small letter, special character and a digit. The lenght should more than 8");
            string password=Console.ReadLine();
            bool isPasswordStrong=VerifyPassword(password);
            if(isPasswordStrong)
            {
                   Console.WriteLine("User Account Created Successfully");
            }
            else
            {
                   Console.WriteLine("Weak Password! User Account not created");
            }
        }

        public static bool VerifyPassword(string password)
        {
            if(password.Length<8)
              {
                  return false;
              }
              return true; 

            
        }
    }
}
