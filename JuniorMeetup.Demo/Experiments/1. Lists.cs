namespace JuniorMeetup.Demo.Experiments;

static class Lists
{
	public static class Append
	{
		const int N = 10_000_000;

		public static List<int> ToArrayList()
		{
			List<int> arrayList = new();

			for (int i = 0; i < N; i++)
			{
				arrayList.Add(i);
			}

			return arrayList;
		}

		public static LinkedList<int> ToLinkedList()
		{
			LinkedList<int> linkedList = new();

			for (int i = 0; i < N; i++)
			{
				linkedList.AddLast(i);
			}

			return linkedList;
		}
	}

	public static class RemoveLast
	{
		public static void FromArrayList(List<int> arrayList)
		{
			while (arrayList.Any())
			{
				arrayList.RemoveAt(arrayList.Count - 1);
			}
		}

		public static void FromLinkedList(LinkedList<int> linkedList)
		{
			while (linkedList.Any())
			{
				linkedList.RemoveLast();
			}
		}
	}

	public static class InsertFirst
	{
		const int N = 200_000;

		public static List<int> ToArrayList()
		{
			List<int> arrayList = new();

			for (int i = 0; i < N; i++)
			{
				arrayList.Insert(0, i);
			}

			return arrayList;
		}

		public static LinkedList<int> ToLinkedList()
		{
			LinkedList<int> linkedList = new();

			for (int i = 0; i < N; i++)
			{
				linkedList.AddFirst(i);
			}

			return linkedList;
		}
	}

	public static class RemoveFirst
	{
		public static void FromArrayList(List<int> arrayList)
		{
			while (arrayList.Any())
			{
				arrayList.RemoveAt(0);
			}
		}

		public static void FromLinkedList(LinkedList<int> linkedList)
		{
			while (linkedList.Any())
			{
				linkedList.RemoveFirst();
			}
		}
	}
}