﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Parser
    {
        public int FirstTerm { get; set; }
        public int SecondTerm { get; set; }
        public char Operator { get; set; }

        public void ParseInput(string input)
        {
            try
            {
                string pattern = @"(\w+)\s*([\+\-*\/%])\s*(\w+)";

                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    FirstTerm = int.Parse(match.Groups[1].Value);
                    Operator = char.Parse(match.Groups[2].Value);
                    SecondTerm = int.Parse(match.Groups[3].Value);
                }
                else
                {
                    throw new ArgumentException("Bad Expression entered.");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Operator = '!';
            }

        }
    }
}
