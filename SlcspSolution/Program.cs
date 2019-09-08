using System;
using System.Collections.Generic;
using System.IO;

namespace SlcspSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For this project to run you will need path files for the csv's to be used in this program. " +
                "if you downloaded the program you can find them in your downloads folder on your computer.");
            var Path = GetPath();
            ReadCSV(Path);
            SplitCSVbyComma(Path);
        }

        static string GetPath()
        {
            Console.WriteLine("Please enter your CSV path");
            String Path = Console.ReadLine();
            return Path;
        }

        static void ReadCSV(string Path)
        {
            using (var Reader = new StreamReader(@Path)) ;
        }

        static void SplitCSVbyComma(string Path)
        {
            if (Path.Contains("plans.csv"))
            {
                List<string> PlanID = new List<string>();
                List<string> State = new List<string>();
                List<string> MetalLevel = new List<string>();
                List<string> Rate = new List<string>();
                List<string> RateArea = new List<string>();
            }
            else if (Path.Contains("slcsp.csv"))
            {
                List<string> ZipCode = new List<string>();
                List<string> Rate = new List<string>();
            }
            else if (Path.Contains("zips.csv"))
            {
                List<string> ZipCode = new List<string>();
                List<string> State = new List<string>();
                List<string> CountyCode = new List<string>();
                List<string> Name = new List<string>();
                List<string> RateArea = new List<string>();
            }
            else
            {
                Console.WriteLine("That is not one of the files supported, try again.");
                SplitCSVbyComma(GetPath());
            }
        }
    }
}
