using System;
using System.Collections.Generic;
using System.IO;

namespace Lottery
{
    class Program
    {
        static void Main()
        {
            string[] lines = File.ReadAllLines("../../../input.txt");
            string[] selectedNumbers = lines[0].Split(' ');
            int n = int.Parse(lines[1]);
            string[] tickets = new string[n];

            for (int i = 0; i < n; i++)
            {
                tickets[i] = lines[i + 2];
            }

            string[] results = CheckTickets(selectedNumbers, tickets);

            File.WriteAllLines("../../../output.txt", results);
        }

        static string[] CheckTickets(string[] selectedNumbers, string[] tickets)
        {
            string[] results = new string[tickets.Length];

            for (int i = 0; i < tickets.Length; i++)
            {
                string[] ticketNumbers = tickets[i].Split(' ');
                int count = 0;

                for(int j = 0; j < selectedNumbers.Length; j++)
                {
                    if (Array.IndexOf(ticketNumbers, selectedNumbers[j]) != -1)
                    {
                        count++;
                    }
                }

                if (count >= 3)
                {
                    results[i] = "Lucky";
                }
                else
                {
                    results[i] = "Unlucky";
                }
            }

            return results;
        }
    }
}
