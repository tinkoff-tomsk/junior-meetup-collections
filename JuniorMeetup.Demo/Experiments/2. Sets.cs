using System.Diagnostics.CodeAnalysis;
using JuniorMeetup.Demo.Dummies;

namespace JuniorMeetup.Demo.Experiments;

[SuppressMessage("ReSharper", "ReturnValueOfPureMethodIsNotUsed")]
static class Sets
{
	public static class Add
	{
		private const int N = 5_000_000;

		public static List<int> ToArrayList()
		{
			List<int> arrayList = new();

			for (int i = 0; i < N; i++)
			{
				arrayList.Add(i);
			}

			return arrayList;
		}

		public static HashSet<int> ToHashSet()
		{
			HashSet<int> hashSet = new();

			for (int i = 0; i < N; i++)
			{
				hashSet.Add(i);
			}

			return hashSet;
		}
	}

	public static class Contains
	{
		private const int N = 50_000;

		public static void InArrayList(List<int> arrayList)
		{
			for (int i = 0; i < N; i++)
			{
				arrayList.Contains(i);
			}
		}

		public static void InHashSet(HashSet<int> hashSet)
		{
			for (int i = 0; i < N; i++)
			{
				hashSet.Contains(i);
			}
		}
	}

	public static class Hashing
	{
		private const int N = 10_000;

		public static HashSet<PoorlyHashedObject> AddPoorlyHashedObjects()
		{
			HashSet<PoorlyHashedObject> hashSet = new();

			for (int i = 0; i < N; i++)
			{
				PoorlyHashedObject poorlyHashedObject = new(i);
				hashSet.Add(poorlyHashedObject);
			}

			return hashSet;
		}

		public static HashSet<ProperlyHashedObject> AddProperlyHashedObjects()
		{
			HashSet<ProperlyHashedObject> hashSet = new();

			for (int i = 0; i < N; i++)
			{
				ProperlyHashedObject properlyHashedObject = new(i);
				hashSet.Add(properlyHashedObject);
			}

			return hashSet;
		}

		public static void SearchPoorlyHashedObjects(HashSet<PoorlyHashedObject> hashSet)
		{
			for (int i = 0; i < N; i++)
			{
				PoorlyHashedObject poorlyHashedObject = new(i);
				hashSet.Contains(poorlyHashedObject);
			}
		}

		public static void SearchProperlyHashedObjects(HashSet<ProperlyHashedObject> hashSet)
		{
			for (int i = 0; i < N; i++)
			{
				ProperlyHashedObject properlyHashedObject = new(i);
				hashSet.Contains(properlyHashedObject);
			}
		}
	}
}