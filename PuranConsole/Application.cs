using System;
using System.Collections.Generic;
using System.Text;

namespace PuranConsole
{
    public class Application
    {
        static List<string> cussWords = new List<string>() { "Fuck", "Heck", "Shit" };

        static List<string> userList = new List<string>();
        private static string AskForUserInput(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            return userInput.ToLower();
        }


        private static bool IsUserNameValid(string userName)
        {
            bool isUserValid = true;

            foreach (var item in cussWords)
            {
                if (userName.ToLower().Contains(item.ToLower()))
                {
                    isUserValid = false;

                    break;
                };
            }

            return isUserValid;

        }

        private static void AddUserToList(bool isUserValid, string userName)
        {
            if (isUserValid == true)
            {
                userList.Add(userName);
                Console.WriteLine("Sucesfully added user to list");
            }
            else
            {
                Console.WriteLine("Sorry You cannot add this UserName");
            }
        }

        private static bool ContinueApp(string askInput)
        {
            if (askInput.ToLower() == "c")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void RunApplication()
        {
            var continueApp = false;
            do
            {
                string userName = AskForUserInput("Enter your name");
                bool isUserValid = IsUserNameValid(userName);
                AddUserToList(isUserValid, userName);
                string askInput = AskForUserInput("Press C to continue and other to exits");
                continueApp = ContinueApp(askInput);

            } while (continueApp);
        }
    }
}
