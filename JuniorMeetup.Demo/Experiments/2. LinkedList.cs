namespace JuniorMeetup.Demo.Experiments;

public static class LinkedListExperiments
{
	public static void Add()
	{
		LinkedList<int> list = new();

		for (int i = 0; i < 100_000_000; i++)
		{
			list.AddLast(i);
		}
	}

	public static void Remove()
	{
		LinkedList<int> list = new();

		for (int i = 0; i < 10_000_000; i++)
		{
			list.AddLast(i);
		}

		while (list.Count > 0)
		{
			list.RemoveFirst();
		}
	}
}