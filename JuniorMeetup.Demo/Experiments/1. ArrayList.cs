namespace JuniorMeetup.Demo.Experiments;

public static class ArrayListExperiments
{
	public static void Add()
	{
		List<int> list = new();

		for (int i = 0; i < 1_000_000_000; i++)
		{
			list.Add(i);
		}
	}

	public static void Clear()
	{
		List<int> list = new();

		for (int i = 0; i < 1_000_000_000; i++)
		{
			list.Add(i);
		}

		list.Clear();
	}
}