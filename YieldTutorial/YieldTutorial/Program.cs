// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using YieldTutorial;

Console.WriteLine("Checking Yield");

//Method to check Yield keyword
ProcessLoopWithYield.DisplayRecordsWithYield();

ProcessLoop.DisplayRecords();

//Uncomment and validate the benchmark.
//var summary = BenchmarkRunner.Run<YieldBenchMark>();






