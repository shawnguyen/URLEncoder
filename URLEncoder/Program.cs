using System;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("URL Encoder");
                Console.WriteLine("Project Name: ");
                string projectName = GetUserInput();
                Console.WriteLine("Activity Name: ");
                string activityName = GetUserInput();

                Console.WriteLine("URL: ");
                Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", projectName, activityName);
                //Console.WriteLine(EncodedURL(projectName, activityName));

                Console.WriteLine("Would you like to do another URL? (yes/no): ");
            } while (Console.ReadLine().ToLower().Equals("yes"));
        }

        /*
        static string CreateURL(string projectName, string activityName)
        {
            Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", projectName, activityName);
            return CreateURL(projectName, activityName);
        }
        */

        static string GetUserInput()
        {
            string input = Console.ReadLine();

            do
            {
                if (IsValid(input)) return input;
                Console.WriteLine("The input has invalid characters, please try again: ");
            } while (true);
        }

        static bool IsValid(string input)
        {
            
        }

        /*
        static string EncodedURL(string projectName, string activityName)
        {
            var url = CreateURL(projectName, activityName);
            var data = System.Web.HttpUtility.UrlEncode(url);
            return data;
        }
        */
    }
}
