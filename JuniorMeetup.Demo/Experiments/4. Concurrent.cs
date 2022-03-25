using System.Collections.Concurrent;

namespace JuniorMeetup.Demo.Experiments;

public static class Concurrent
{
	private const int TasksCount = 10;
	private const int N = 1_000_000;

	public static class ArrayList
	{
		public static List<int> Add()
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

		public static List<int> AddWithLock()
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

	public static class Bag
	{
		public static ConcurrentBag<int> Add()
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