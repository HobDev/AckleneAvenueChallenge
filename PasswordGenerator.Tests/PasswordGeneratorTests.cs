using System;
using Xunit;

namespace PasswordGenerator.Tests
{
    public class UnitTest1
    {
     [Theory]
[InlineData("q23enjiu")]
[InlineData("12gy675")]
public void DefaultPasswordLengthShouldBeEight(string value)
{
  GeneratePassword passwordGenerator=new GeneratePassword();

   bool isValid=passwordGenerator.VerifyPassword(value);
    Assert.True(isValid, "Password length should be 8");
    
}
    }
}
