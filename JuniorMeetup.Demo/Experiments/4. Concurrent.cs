using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Attributes;

namespace JuniorMeetup.Demo.Experiments;

[SuppressMessage("ReSharper", "ClassCanBeSealed.Global")]
public static class Concurrent
{
	private const int TasksCount = 10;
	private const int N = 1_000_000;

	[MemoryDiagnoser]
	public class ArrayList
	{
		public List<int> Add()
		{
			List<int> arrayList = new();
			var addTasks = new Task[TasksCount];

			for (int i = 0; i < TasksCount; i++)
			{
				addTasks[i] = Task.Run(() =>
				{
					for (int j = 0; j < N; j++)
					{
						arrayList.Add(j);
					}
				});
			}

			Task.WaitAll(addTasks);

			return arrayList;
		}

		[Benchmark]
		public List<int> AddWithLock()
		{
			List<int> arrayList = new();
			var addTasks = new Task[TasksCount];
			object lockObject = new();

			for (int i = 0; i < TasksCount; i++)
			{
				addTasks[i] = Task.Run(() =>
				{
					for (int j = 0; j < N; j++)
					{
						lock (lockObject)
						{
							arrayList.Add(j);
						}
					}
				});
			}

			Task.WaitAll(addTasks);

			return arrayList;
		}
	}

	[MemoryDiagnoser]
	public class Bag
	{
		[Benchmark]
		public ConcurrentBag<int> Add()
		{
			ConcurrentBag<int> concurrentBag = new();
			var addTasks = new Task[TasksCount];

			for (int i = 0; i < TasksCount; i++)
			{
				addTasks[i] = Task.Run(() =>
				{
					for (int j = 0; j < N; j++)
					{
						concurrentBag.Add(j);
					}
				});
			}

			Task.WaitAll(addTasks);

			return concurrentBag;
		}
	}
}