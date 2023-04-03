using System;

namespace Registration_Services
{
    internal class Program
    {
        static string[] nicknames = new string[12];
        static string[] passwords = new string[12];
        static void Main(string[] args)
        {
            SeedData();
            ApplicationStart();
        }

        static void SeedData()
        {
            nicknames[0] = "Samir";
            passwords[0] = "Salam123";

            nicknames[1] = "Faiq";
            passwords[1] = "Salam123";

            nicknames[2] = "Afsana";
            passwords[2] = "Salam10";
        }

        static void ApplicationStart()
        {
            Console.Title = "Sign Form";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("SignForm");
            Console.ResetColor();

            Console.WriteLine("1.SignIn");
            Console.WriteLine("2.SignUp");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                SignIn();
            }
            else if (choice == "2")
            {
                SignUp();
            }
        }


        static void SignIn()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("------------------>SignIn<------------------");
            Console.ResetColor();

            Console.Write("Name Input:");
            string nickName = Console.ReadLine();

            
            while (CheckFindName(nickName) == false)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("There are no nicknames with this name!");
                Console.ResetColor();
                nickName = Console.ReadLine();
            }

            Console.Write("Password input:");
            string password = Console.ReadLine();

            while (CheckFindPassword(password) == false)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("The password is incorrect!");
                Console.ResetColor();
                password = Console.ReadLine();

            }

            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("SUCCESFULL")

        }

        //static bool CheckFind(string nickName,string password)
        //{   bool n1=false
        //    for (int i = 0; i <nicknames.Length i++)
        //    {
        //        for (int j = 0; j < passwords.Length; j++)
        //        {
        //            if (nicknames[i].Length ==passwords[j].Length)
        //            {
        //                n1 = false;
        //            }
        //        }

        //    }
        //    return n1;

        static bool CheckFindName( string nickName)
        {
            bool not1 = false;
            int count = 0;
            for (int i = 0; i < nicknames.Length; i++)
            {
                if (nickName == nicknames[i])
                {
                    not1 = true;
                    count++;
                }
            }
            return not1;
        }
        static bool CheckFindPassword( string password)
        {
            bool not = false;
            for (int i = 0; i <passwords.Length; i++)
            {
                if (password == passwords[CheckFindName(count)])
                {
                    not=true;
                }
            }
            return not;
        }


        static void SignUp()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------>SignUp<------------------");
            Console.ResetColor();

            Console.Write("Name Input:");
            string nickName = Console.ReadLine();

            while (ChecknickName(nickName) == false)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Try again NickName!!");
                Console.ResetColor();
                nickName = Console.ReadLine();

            }



            Console.Write("Password input:");
            string password = Console.ReadLine();

            while (ChecknickPassword(password) == false)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Try again Password!!! 1 Uppercase,1 Digit, 1 Symbol and 12 lenght");
                Console.ResetColor();
                password = Console.ReadLine();

            }
            //Console.ReadKey();
            Console.Clear();
            ApplicationStart();


        }



        static bool ChecknickName(string nickName)
        {
            //return (false);
            bool notexits = true;
            for (int i = 0; i < nicknames.Length; i++)
            {
                if (nickName == nicknames[i])
                {
                    notexits = false;
                    break;
                }
            }
            return notexits;
        }
        static bool ChecknickPassword(string password)
        {
            if (password.Length < 12) return false;

            bool hasDigit = false;
            bool hasSymbol = false;
            bool hasUpper = false;


            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i])) hasDigit = true;
                if (char.IsUpper(password[i])) hasUpper = true;
                if (char.IsSymbol(password[i])) hasSymbol = true;

            }
            if (hasDigit && hasSymbol&&hasUpper) return true;
            return false;
        }
    }
}
