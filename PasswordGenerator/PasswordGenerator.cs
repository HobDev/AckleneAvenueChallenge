using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PasswordGenerator
{
   public class GeneratePassword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Name!");
            string userName=Console.ReadLine();
            Console.WriteLine("Password! Must include a Capital letter, a small letter, a special character and a digit. The password lenght should be more than 8");
            string password=Console.ReadLine();
            (bool, string) isPasswordStrong=VerifyPasswordStrength(password);
            if(isPasswordStrong.Item1)
            {
                   Console.WriteLine("User Account Created Successfully");
            }
            else
            {
                   Console.WriteLine(isPasswordStrong.Item2);
            }
        }

        public static (bool,string) VerifyPasswordStrength(string password)
      {
          string message="";
          bool isPasswordStrong=true;
          StringBuilder sb=new StringBuilder("Weak password:--");
            
              if(password.Length<8)
              {
                  sb.Append("Length is less than 8--");
                  isPasswordStrong=false;
              }
              if( !password.Any(char.IsUpper))
              {
                  sb.Append("No upper Case letter--");
                   isPasswordStrong=false;
              }
              if(!password.Any(char.IsLower))
      {
          sb.Append("No lower case letter--");
           isPasswordStrong=false;
      }
      if(!password.Any(char.IsDigit))
      {
          sb.Append("No numbers--");
           isPasswordStrong=false;
      }
      if(!password.Any(ch=>!char.IsLetterOrDigit(ch)))
      {
          sb.Append("No special character--");
           isPasswordStrong=false;
      }
      message=sb.ToString();
              return (isPasswordStrong,message);         
        }
    }
}
