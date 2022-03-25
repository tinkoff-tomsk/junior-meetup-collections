using System.Diagnostics.CodeAnalysis;

namespace JuniorMeetup.Demo.Experiments;

[SuppressMessage("ReSharper", "ReturnValueOfPureMethodIsNotUsed")]
internal static class Sorted
{
	public static class Add
	{
		private const int N = 5_000_000;

		public static HashSet<int> ToHashSet()
		{
			HashSet<int> hashSet = new();

			for (int i = 0; i < N; i++)
			{
				hashSet.Add(i);
			}

			return hashSet;
		}

		public static SortedSet<int> ToSortedSet()
		{
			SortedSet<int> sortedSet = new();

			for (int i = 0; i < N; i++)
			{
				sortedSet.Add(i);
			}

			return sortedSet;
		}
	}

	public static class Contains
	{
		private const int N = 5_000_000;

		public static void InHashSet(HashSet<int> hashSet)
		{
			for (int i = 0; i < N; i++)
			{
				hashSet.Contains(i);
			}
		}

		public static void InSortedSet(SortedSet<int> sortedSet)
		{
			for (int i = 0; i < N; i++)
			{
				sortedSet.Contains(i);
			}
		}
	}

	public static class SetVsArray
	{
		private const int N = 1_000_000;

		public static int[] GetRandomNumbers()
		{
			Random random = new();

			return Enumerable
				.Range(0, N)
				.OrderBy(_ => random.Next())
				.ToArray();
		}

		public static int[] CreateSortedArray(int[] randomNumbers)
		{
			var array = new int[N];

			Array.Copy(randomNumbers, array, N);
			Array.Sort(array);

			return array;
		}

		public static SortedSet<int> CreateSortedSet(int[] randomNumbers) => new(randomNumbers);

		public static void SearchInArray(int[] sortedArray)
		{
			for (int i = N; i >= 0; i--)
			{
				Array.BinarySearch(sortedArray, i);
			}
		}

		public static void SearchInSet(SortedSet<int> sortedSet)
		{
			for (int i = N; i >= 0; i--)
			{
				sortedSet.Contains(i);
			}
		}
	}
}