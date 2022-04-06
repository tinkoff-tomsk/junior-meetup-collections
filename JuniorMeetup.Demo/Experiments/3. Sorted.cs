using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Attributes;

namespace JuniorMeetup.Demo.Experiments;

[SuppressMessage("ReSharper", "ClassCanBeSealed.Global")]
[SuppressMessage("ReSharper", "ReturnValueOfPureMethodIsNotUsed")]
public static class Sorted
{
	[MemoryDiagnoser]
	public class Add
	{
		private const int N = 5_000_000;

		[Benchmark]
		public HashSet<int> ToHashSet()
		{
			HashSet<int> hashSet = new();

			for (int i = 0; i < N; i++)
			{
				hashSet.Add(i);
			}

			return hashSet;
		}

		[Benchmark]
		public SortedSet<int> ToSortedSet()
		{
			SortedSet<int> sortedSet = new();

			for (int i = 0; i < N; i++)
			{
				sortedSet.Add(i);
			}

			return sortedSet;
		}
	}

	[MemoryDiagnoser]
	public class Contains
	{
		private const int N = 5_000_000;

		private readonly HashSet<int> _hashSet;
		private readonly SortedSet<int> _sortedSet;

		public Contains()
		{
			Add add = new();

			_hashSet = add.ToHashSet();
			_sortedSet = add.ToSortedSet();
		}

		[Benchmark]
		public void InHashSet()
		{
			for (int i = 0; i < N; i++)
			{
				_hashSet.Contains(i);
			}
		}

		[Benchmark]
		public void InSortedSet()
		{
			for (int i = 0; i < N; i++)
			{
				_sortedSet.Contains(i);
			}
		}
	}

	[MemoryDiagnoser]
	public class SetVsArray
	{
		private const int N = 1_000_000;

		private readonly int[] _randomNumbers = GetRandomNumbers();

		private readonly int[] _sortedArray;
		private readonly SortedSet<int> _sortedSet;

		public SetVsArray()
		{
			_sortedArray = CreateSortedArray();
			_sortedSet = CreateSortedSet();
		}

		[Benchmark]
		public int[] CreateSortedArray()
		{
			var array = new int[N];

			Array.Copy(_randomNumbers, array, N);
			Array.Sort(array);

			return array;
		}

		[Benchmark]
		public SortedSet<int> CreateSortedSet() => new(_randomNumbers);

		[Benchmark]
		public void SearchInArray()
		{
			for (int i = N; i >= 0; i--)
			{
				Array.BinarySearch(_sortedArray, i);
			}
		}

		[Benchmark]
		public void SearchInSet()
		{
			for (int i = N; i >= 0; i--)
			{
				_sortedSet.Contains(i);
			}
		}

		private static int[] GetRandomNumbers()
		{
			Random random = new();

			return Enumerable
				.Range(0, N)
				.OrderBy(_ => random.Next())
				.ToArray();
		}
	}
}