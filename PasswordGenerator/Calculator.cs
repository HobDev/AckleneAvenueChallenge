using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PasswordGenerator
{
   public class Calculator
    {
       public int Add(string input="0") {
           
           if (input.Length == 1) return Convert.ToInt32(input);
           if (input.Length == 3) return Convert.ToInt32(input[0].ToString()) + Convert.ToInt32(input[2].ToString());
          if(input=="0") return Convert.ToInt32(input);
          var inputs=input.Split(',');
          int sum=0;
          for(int i=0;i<inputs.Length;i++)
           {
              sum+= Convert.ToInt32(inputs[i]);
           }
           return sum;
        }
    }
}
