using System;
using System.Collections.Generic;

namespace Things__App_
{
    class Program
    {
        private static readonly String EXIT_COMMAND         = "exit";
        private static readonly String HELP_COMMAND         = "help";
        private static readonly String MAKE_COMMAND         = "make";
        private static readonly String CONFIG_COMMAND       = "config";

        static void Main(string[] args)
        {
            // preliminary instructions
            Console.WriteLine("Hello, and Welcome to Things App!\n");
            Console.WriteLine("Things makes your life easier, by helping you keep\n" +
                              "track of all of that shit you've got going on up there!\n" +
                              "From day-to-day tasking, to long term goal-setting,\n" +
                              "Things can help you organize the files in your brain.\n");
            Console.WriteLine("Type \"help\" for detailed usage instructions and Things docmumentation.");
            Console.WriteLine("Type \"exit\" or nothing to exit.");
            Console.WriteLine("Developed by Ryan P. Hill in 2020 for personal use.");

            // receive initial response
            String response = Console.ReadLine().Trim().ToLower();

            // =========
            // MAIN LOOP
            // =========
            // (terminates if you type a prefix of "exit"
            while (!EXIT_COMMAND.StartsWith(response))
            {
                if (HELP_COMMAND.StartsWith(response))
                {
                    // TODO Main Loop: Output help message
                }
                else if (MAKE_COMMAND.StartsWith(response))
                {
                    // TODO Main Loop: Make a fucking Thing
                }
                else
                {
                    Console.WriteLine($"Invalid Command: {response}\n(Please try again. Type \"help\" if you need help.)");
                }
                //receive next response
                response = Console.ReadLine().Trim().ToLower();
            }
            return;
        }
    }
}
