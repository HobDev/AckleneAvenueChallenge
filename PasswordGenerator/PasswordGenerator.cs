using System;

namespace PasswordGenerator
{
   public class GeneratePassword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool VerifyPassword(string password)
        {
              if(password.Length<8)
              {
                  return false;
              }
              return true;
        }
    }
}
