using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace JuniorMeetup.Demo.Utilities;

static class MeasuringUtilities
{
	public static void MeasureTime(Action action, [CallerArgumentExpression("action")] string? expression = null)
	{
		MeasureTime(
			() =>
			{
				action();
				return true;
			},
			expression);
	}

	public static T MeasureTime<T>(Func<T> func, [CallerArgumentExpression("func")] string? expression = null)
	{
		var stopwatch = Stopwatch.StartNew();

		T result = func();

		stopwatch.Stop();
		Console.WriteLine($"{expression,-75}{stopwatch.Elapsed}");

		return result;
	}

	public static void MeasureMemory(Action action, [CallerArgumentExpression("action")] string? expression = null)
	{
		long workingSetBefore = GetWorkingSetInMegabytes();
		Console.WriteLine($"{expression}. Memory consumption before: {workingSetBefore} MB");

		action();

		long workingSetAfter = GetWorkingSetInMegabytes();
		Console.WriteLine($"{expression}. Memory consumption after:  {workingSetAfter} MB");

		GC.Collect();
	}

	private static long GetWorkingSetInMegabytes()
	{
		return Process.GetCurrentProcess().WorkingSet64 / 1_000_000;
	}
}