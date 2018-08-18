using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHouse1
{
    public static class UI
    {
        public static bool UserAnswersYes(string question)
        {
            // TODO: improve this method and make it cleaner

            Console.WriteLine(question);

            string response = Console.ReadLine().ToLower();

            if(response == "y" || response == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
