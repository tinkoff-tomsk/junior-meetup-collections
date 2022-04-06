// ReSharper disable CommentTypo

using BenchmarkDotNet.Running;
using JuniorMeetup.Demo.Experiments;

BenchmarkRunner.Run<Lists.Append>();
BenchmarkRunner.Run<Lists.RemoveLast>();
BenchmarkRunner.Run<Lists.InsertFirst>();
BenchmarkRunner.Run<Lists.RemoveFirst>();

BenchmarkRunner.Run<Sets.Add>();
BenchmarkRunner.Run<Sets.Contains>();
BenchmarkRunner.Run<Sets.AddWithDifferentHashing>();
BenchmarkRunner.Run<Sets.ContainsWithDifferentHashing>();

BenchmarkRunner.Run<Sorted.Add>();
BenchmarkRunner.Run<Sorted.Contains>();
BenchmarkRunner.Run<Sorted.SetVsArray>();

BenchmarkRunner.Run<Concurrent.ArrayList>();
BenchmarkRunner.Run<Concurrent.Bag>();

// Код ниже может выдать исключение. Это нормально.

// Concurrent.ArrayList experiment = new();
// var result = experiment.Add();
// Console.WriteLine();
// Console.WriteLine($"{result.Count:N0} elements successfully added to the array list");