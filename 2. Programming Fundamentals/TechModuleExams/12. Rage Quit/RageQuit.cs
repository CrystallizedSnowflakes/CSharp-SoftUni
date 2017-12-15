﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            var msg = Console.ReadLine().ToUpper();
            var pattern = @"(?<symbols>[^0-9]+)(?<number>[0-9]+)";
            var finalMsg = new StringBuilder();

            var matches = Regex.Matches(msg, pattern);

            foreach (Match m in matches)
            {
                var text = m.Groups["symbols"].Value;
                var repeat = int.Parse(m.Groups["number"].ToString());

                finalMsg.Append(new StringBuilder().Insert(0, text, repeat));
            }

            var uniqueChars = finalMsg.ToString().ToCharArray().Distinct().ToList().Count;

            Console.WriteLine($"Unique symbols used: {uniqueChars}");
            Console.WriteLine(finalMsg);
        }
    }
}
