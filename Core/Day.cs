using System;
using System.Diagnostics;

namespace AdventOfCode.Core {
    public abstract class Day {
        public int day { get; protected set; }
        public int year { get; protected set; }
        protected string title { get; set; }
        
        protected virtual dynamic PrepareCommon(string[] puzzleInput) => puzzleInput;
        protected abstract int GetPartOne(dynamic key);
        protected abstract int GetPartTwo(dynamic key);

        protected static string[] PreparePuzzleInput(string pathToInput) => Utils.getInput(pathToInput);
        
        public void GetResults() {
            var key = PrepareCommon(PreparePuzzleInput(string.Format("./Y{0}/PuzzleInputs/day{1}.txt", this.year, this.day.ToString("00"))));

            var watch = new Stopwatch();

            Console.WriteLine( "--- Day " + this.day + ": " + this.title + " ---");
            
            watch.Start();
            var partOne = GetPartOne(key);
            watch.Stop();
            Console.WriteLine("Part 1: " + partOne + " (" + watch.ElapsedMilliseconds + " ms)");
            
            watch.Start();
            var partTwo = GetPartTwo(key);
            watch.Stop();
            Console.WriteLine("Part 2: " + partTwo + " (" + watch.ElapsedMilliseconds + " ms)");
        }
    }
}
