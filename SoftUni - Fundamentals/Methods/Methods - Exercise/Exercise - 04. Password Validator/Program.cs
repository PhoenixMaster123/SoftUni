using System;

namespace Exercise___04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string password = Console.ReadLine();
            bool isPasswordValid = ValidatePassword(password);
           if(isPasswordValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool ValidatePassword(string password)
        {
            const int passwordMinLenght = 6;
            const int passwordMaxLenght = 10;
            const int minDigitsCount = 2;
            bool isPasswordValid = true;
            if(!ValidatePasswordLenght(password,passwordMinLenght, passwordMaxLenght))
            {
                Console.WriteLine($"Password must be between {passwordMinLenght} and {passwordMaxLenght} characters");
                isPasswordValid = false;
            }
            if(!ValidateIsAlphaNumerical(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isPasswordValid=false;
            }
            if(!ValidatePasswordDigitsMinCount(password, minDigitsCount))
            {
                Console.WriteLine($"Password must have at least {minDigitsCount} digits");
                isPasswordValid = false;
            }
            return isPasswordValid;
        }
        static bool ValidatePasswordLenght(string password, int minLenght, int maxLenght)
        {
            if(password.Length>=minLenght && password.Length<=maxLenght)
            {
                return true;
            }
            return false;
        }
        static bool ValidateIsAlphaNumerical(string password)
        {
            foreach (char ch in password)
            {
                if(!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }             
            }
            return true;
        }
        static bool ValidatePasswordDigitsMinCount(string password, int minDigitsCount)
        {
            int digitsCount = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCount++;
                }
                
            }
            return digitsCount >= minDigitsCount;
        }
            
         
    }
}
