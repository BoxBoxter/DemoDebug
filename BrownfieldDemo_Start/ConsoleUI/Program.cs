using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string w;
            int i, t, ttl;
            bool cont = false;
            List<TimeSheetEntry> ents = new List<TimeSheetEntry>(); // lista tiempo
            Console.Write("Enter what you did: ");
            w = Console.ReadLine(); // W contains what did
            Console.Write("How long did you do it for: ");
            t = int.Parse(Console.ReadLine()); // t contains hours
            TimeSheetEntry ent = new TimeSheetEntry(); // funcion de tiempo ? buscar gogole
            ent.HoursWorked = t;
            ent.WorkDone = w;
            ents.Add(ent);
            Console.Write("Do you want to enter more time:");

            //1. First error yes or no y not a bolean option // solution make a if for yes option, because other option are farse
            // Solution make a string condition with yes or no I know its better with boolen but i have to MVP
            string x = Console.ReadLine();
            if (x.Equals("yes"))
            {
                do
                {
                    Console.Write("Enter what you did: ");
                    w = Console.ReadLine();
                    Console.Write("How long did you do it for: ");
                    t = int.Parse(Console.ReadLine());
                    ent.HoursWorked = t;
                    ent.WorkDone = w;
                    ents.Add(ent);
                    Console.Write("Do you want to enter more time:");
                    x = Console.ReadLine();
                    if (x.Equals("no"))
                    {
                        cont = false;
                    }
                    else
                    { cont = true; }
                    //cont = bool.Parse(Console.ReadLine());
                } while (cont == true);
            }
            //Boolean cont = Boolean.TryParse(x, out bool result);
            ttl = 0;
            // 2. Acme is in lower case
            // 3. Don't contain ACME activitys

            //5. the first postion of acctivitis don't detect ACME or ABC
            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.Contains("ACME"))
                {
                    ttl += i;
                }
            }
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + ttl * 150 + " for the hours worked.");

            // 4. don't erase ttl soo abc ttl are always more 
            // Solution declare ttl again to 0
            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.Contains("ABC"))
                {
                    ttl += i;
                }
            }
            
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + ttl * 125 + " for the hours worked.");
            for (i = 0; i < ents.Count; i++)
            {
                ttl += ents[i].HoursWorked;
            }
            if (ttl > 40)
            {
                Console.WriteLine("You will get paid $" + ttl * 15 + " for your work.");
            }
            else
            {
                Console.WriteLine("You will get paid $" + ttl * 10 + " for your time.");
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public int HoursWorked;
    }
}
