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
		long workingSetBefore = GetWorkingSetInBytes();
		action();
		long workingSetAfter = GetWorkingSetInBytes();

		double setBefore = (workingSetAfter - workingSetBefore) / 1_000_000.0;
		Console.WriteLine($"{expression,-75}{setBefore,10:N2} MB");

		GC.Collect();
	}

	private static long GetWorkingSetInBytes()
	{
		return Process.GetCurrentProcess().WorkingSet64;
	}
}