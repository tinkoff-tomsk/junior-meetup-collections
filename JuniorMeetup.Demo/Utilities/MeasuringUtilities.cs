using System.Diagnostics;

namespace JuniorMeetup.Demo.Utilities;

public static class MeasuringUtilities
{
	public static void MeasureTime(Action action)
	{
		var stopwatch = Stopwatch.StartNew();

		action();

		stopwatch.Stop();
		Console.WriteLine($"Elapsed time: {stopwatch.Elapsed}");
	}

	public static void MeasureMemory(Action action)
	{
		long workingSetBefore = GetWorkingSetInMegabytes();
		Console.WriteLine($"Memory consumption before: {workingSetBefore} MB");

		action();

		long workingSetAfter = GetWorkingSetInMegabytes();
		Console.WriteLine($"Memory consumption after: {workingSetAfter} MB");
	}

	private static long GetWorkingSetInMegabytes()
	{
		return Process.GetCurrentProcess().WorkingSet64 / 1_000_000;
	}
}