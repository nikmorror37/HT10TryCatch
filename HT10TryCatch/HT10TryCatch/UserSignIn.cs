using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT10TryCatch
{
    class UserSignIn
    {
        public static bool UserRegistration(string login, string password, string confirmPassword)
        {
            bool registrationSuccessful = true;
            var NumberFromCharArray = new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};

            if (login.Length >= 20) 
                throw new WrongLoginException("Длина login должна быть меньше 20 символов");
            if (password.Length >= 20) 
                throw new WrongPasswordException("Длина password должна быть меньше 20 символов");
            
            if (login.Contains(' ')) 
                throw new WrongLoginException("Login не должен содержать пробелы");
            if (password.Contains(' ')) 
                throw new WrongPasswordException("Password не должен содержать пробелы");
            
            if (password.IndexOfAny(NumberFromCharArray) == -1) 
                throw new WrongPasswordException("Password должен содержать хотя бы одну цифру");
            
            if (!password.Equals(confirmPassword)) 
                throw new WrongPasswordException("Passwords не совпадают, проверьте confirmPassword");
            
            return registrationSuccessful;
        }
    }
}
