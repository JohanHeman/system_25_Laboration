// See https://aka.ms/new-console-template for more information

using _2015DayOne;
using AdventOfCode.Common;
using Y2021D01;
using Console = System.Console;

// Console.WriteLine("Hello, World!");
// var path = Path.Combine(AppContext.BaseDirectory, "input.txt");
// var text = File.ReadAllText(path);

// var depths = Input.Numbers(text);
// var sonar = new Sonar();
// var increases = sonar.CountIncreases(depths);
//
// Console.WriteLine($"The file contained {depths.Length} entries, and they increased {increases} times.");
//

var path = Path.Combine(AppContext.BaseDirectory, "ElevatorInput.txt");

var input = File.ReadAllText(path).Trim();

var floorTracker = new FloorTracker();

var result = floorTracker.TrackFloor(input);
Console.WriteLine(result);