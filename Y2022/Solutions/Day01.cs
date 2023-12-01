using AdventOfCode.Core;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Y2022.Solutions {
    public class Day01 : Day {
       
        protected override dynamic PrepareCommon(string[] puzzleInput) {
            int elf = 0;
            var elfCalorieStorage = new List<int> {};

            foreach (var line in puzzleInput) {
                if (line != "") {
                    elf += int.Parse(line);
                } else {
                    elfCalorieStorage.Add(elf);
                    elf = 0;
                }
            };
            
            return elfCalorieStorage.OrderByDescending(x => x).ToList();
        }

        protected override int GetPartOne(dynamic key) => ((List<int>)key).First();

        protected override int GetPartTwo(dynamic key) {
            List<int> elfCalorieStorage = (List<int>)key;
            return (elfCalorieStorage[0] + elfCalorieStorage[1] + elfCalorieStorage[2]);
        }

        public Day01() {
            day = 1;
            year = 2022;
            title = "Calorie counting";
        }
    }
}
