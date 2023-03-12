using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT10TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                bool registrationDone = UserSignIn.UserRegistration("nikolay1988", "13Petrovich!", "13Petrovich!");
                if (registrationDone) 
                    Console.WriteLine("Регистрация прошла успешно, логин и пароль сохранены");
            }
            catch (WrongLoginException ex) 
            {
                Console.WriteLine(ex.Message); 
            }
            catch (WrongPasswordException ex) 
            {
                Console.WriteLine(ex.Message); 
            }

        }
    }

}