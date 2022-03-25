using JuniorMeetup.Demo.Experiments;
using JuniorMeetup.Demo.Utilities;

Console.WriteLine();
Console.WriteLine("Lists.Append:");
var  arrayList = MeasuringUtilities.MeasureTime(Lists.Append.ToArrayList);
var linkedList = MeasuringUtilities.MeasureTime(Lists.Append.ToLinkedList);

// Console.WriteLine();
// Console.WriteLine("Lists.Append:");
// MeasuringUtilities.MeasureMemory(() => Lists.Append.ToArrayList());
// MeasuringUtilities.MeasureMemory(() => Lists.Append.ToLinkedList());

// Console.WriteLine();
// Console.WriteLine("Lists.RemoveLast:");
// MeasuringUtilities.MeasureTime(() => Lists.RemoveLast.FromArrayList(arrayList));
// MeasuringUtilities.MeasureTime(() => Lists.RemoveLast.FromLinkedList(linkedList));

// Console.WriteLine();
// Console.WriteLine("Lists.InsertFirst:");
// var  arrayList = MeasuringUtilities.MeasureTime(Lists.InsertFirst.ToArrayList);
// var linkedList = MeasuringUtilities.MeasureTime(Lists.InsertFirst.ToLinkedList);

// Console.WriteLine();
// Console.WriteLine("Lists.RemoveFirst:");
// MeasuringUtilities.MeasureTime(() => Lists.RemoveFirst.FromArrayList(arrayList));
// MeasuringUtilities.MeasureTime(() => Lists.RemoveFirst.FromLinkedList(linkedList));

// Console.WriteLine();
// Console.WriteLine("Sets.Add:");
// var arrayList = MeasuringUtilities.MeasureTime(Sets.Add.ToArrayList);
// var hashSet   = MeasuringUtilities.MeasureTime(Sets.Add.ToHashSet);

// Console.WriteLine();
// Console.WriteLine("Sets.Contains:");
// MeasuringUtilities.MeasureTime(() => Sets.Contains.InArrayList(arrayList));
// MeasuringUtilities.MeasureTime(() => Sets.Contains.InHashSet(hashSet));

// Console.WriteLine();
// Console.WriteLine("Sets.Hashing.Add");
// var   poorlyHashedObjects = MeasuringUtilities.MeasureTime(Sets.Hashing.AddPoorlyHashedObjects);
// var properlyHashedObjects = MeasuringUtilities.MeasureTime(Sets.Hashing.AddProperlyHashedObjects);

// Console.WriteLine();
// Console.WriteLine("Sets.Hashing.Search");
// MeasuringUtilities.MeasureTime(() => Sets.Hashing.SearchPoorlyHashedObjects(poorlyHashedObjects));
// MeasuringUtilities.MeasureTime(() => Sets.Hashing.SearchProperlyHashedObjects(properlyHashedObjects));

// Console.WriteLine();
// Console.WriteLine("Sorted.Add:");
// var   hashSet = MeasuringUtilities.MeasureTime(Sorted.Add.ToHashSet);
// var sortedSet = MeasuringUtilities.MeasureTime(Sorted.Add.ToSortedSet);

// Console.WriteLine();
// Console.WriteLine("Sorted.Contains:");
// MeasuringUtilities.MeasureTime(() => Sorted.Contains.InHashSet(hashSet));
// MeasuringUtilities.MeasureTime(() => Sorted.Contains.InSortedSet(sortedSet));

// Console.WriteLine();
// Console.WriteLine("Lists.Append:");
// MeasuringUtilities.MeasureMemory(() => Sorted.Add.ToHashSet());
// MeasuringUtilities.MeasureMemory(() => Sorted.Add.ToSortedSet());

// var randomNumbers = Sorted.SetVsArray.GetRandomNumbers();

// Console.WriteLine();
// Console.WriteLine("Sorted.SetVsArray.Create:");
// var sortedArray = MeasuringUtilities.MeasureTime(() => Sorted.SetVsArray.CreateSortedArray(randomNumbers));
// var sortedSet   = MeasuringUtilities.MeasureTime(() => Sorted.SetVsArray.CreateSortedSet(randomNumbers));

// Console.WriteLine();
// Console.WriteLine("Sorted.SetVsArray.Search");
// MeasuringUtilities.MeasureTime(() => Sorted.SetVsArray.SearchInArray(sortedArray));
// MeasuringUtilities.MeasureTime(() => Sorted.SetVsArray.SearchInSet(sortedSet));

// Console.WriteLine();
// Console.WriteLine("Sorted.SetVsArray.Create:");
// MeasuringUtilities.MeasureMemory(() => Sorted.SetVsArray.CreateSortedArray(randomNumbers));
// MeasuringUtilities.MeasureMemory(() => Sorted.SetVsArray.CreateSortedSet(randomNumbers));

// var result = Concurrent.ArrayList.Add();
// var result = Concurrent.ArrayList.AddWithLock();
// Console.WriteLine(result.Count);

// MeasuringUtilities.MeasureTime(Concurrent.ArrayList.AddWithLock);
// MeasuringUtilities.MeasureTime(Concurrent.Bag.Add);
