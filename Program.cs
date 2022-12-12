using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Core;

namespace AdventOfCode {
    
    class Program {
        static void Main(string[] args) {

            List<Day> days = Services.createDaysSolutions();

            // in case of no arguments, it will get the results of the last solution added
            if (args.Length == 0) {
                days.LastOrDefault().getResults();
            }
            // if the format is yyyy dd, the program will return the results of that day
            else if (args.Length == 2) {
                foreach(Day day in days) {
                    if (day.year == int.Parse(args[0]) && day.day == int.Parse(args[1])) {
                        day.getResults();
                    }
                }
            } else {
                Services.printInstructions();
            }
            
        }    
    }
}
