using JuniorMeetup.Demo.Experiments;
using JuniorMeetup.Demo.Utilities;

// 1. List creation speed

Console.WriteLine();
Console.WriteLine("1. List creation speed");
var  arrayList = MeasuringUtilities.MeasureTime(Lists.Append.ToArrayList);
var linkedList = MeasuringUtilities.MeasureTime(Lists.Append.ToLinkedList);

// 2. List creation memory

// Console.WriteLine();
// Console.WriteLine("2. List creation memory");
// MeasuringUtilities.MeasureMemory(() => Lists.Append.ToArrayList());
// MeasuringUtilities.MeasureMemory(() => Lists.Append.ToLinkedList());

// 3. Last element removal

// Console.WriteLine();
// Console.WriteLine("1. List creation speed");
// var  arrayList = MeasuringUtilities.MeasureTime(Lists.Append.ToArrayList);
// var linkedList = MeasuringUtilities.MeasureTime(Lists.Append.ToLinkedList);
//
// Console.WriteLine();
// Console.WriteLine("3. Last element removal");
// MeasuringUtilities.MeasureTime(() => Lists.RemoveLast.FromArrayList(arrayList));
// MeasuringUtilities.MeasureTime(() => Lists.RemoveLast.FromLinkedList(linkedList));

// 4. First element insertion and removal

// Console.WriteLine();
// Console.WriteLine("4.1. First element insertion");
// var  arrayList = MeasuringUtilities.MeasureTime(Lists.InsertFirst.ToArrayList);
// var linkedList = MeasuringUtilities.MeasureTime(Lists.InsertFirst.ToLinkedList);
//
// Console.WriteLine();
// Console.WriteLine("4.2. First element removal");
// MeasuringUtilities.MeasureTime(() => Lists.RemoveFirst.FromArrayList(arrayList));
// MeasuringUtilities.MeasureTime(() => Lists.RemoveFirst.FromLinkedList(linkedList));

// 5. Set vs ArrayList

// Console.WriteLine();
// Console.WriteLine("5.1. Set vs ArrayList. Creation");
// var arrayList = MeasuringUtilities.MeasureTime(Sets.Add.ToArrayList);
// var hashSet   = MeasuringUtilities.MeasureTime(Sets.Add.ToHashSet);
//
// Console.WriteLine();
// Console.WriteLine("5.2. Set vs ArrayList. Search");
// MeasuringUtilities.MeasureTime(() => Sets.Contains.InArrayList(arrayList));
// MeasuringUtilities.MeasureTime(() => Sets.Contains.InHashSet(hashSet));

// 6. Poor vs proper hashing

// Console.WriteLine();
// Console.WriteLine("6.1. Poor vs proper hashing. Set creation");
// var   poorlyHashedObjects = MeasuringUtilities.MeasureTime(Sets.Hashing.AddPoorlyHashedObjects);
// var properlyHashedObjects = MeasuringUtilities.MeasureTime(Sets.Hashing.AddProperlyHashedObjects);
//
// Console.WriteLine();
// Console.WriteLine("6.2. Poor vs proper hashing. Search");
// MeasuringUtilities.MeasureTime(() => Sets.Hashing.SearchPoorlyHashedObjects(poorlyHashedObjects));
// MeasuringUtilities.MeasureTime(() => Sets.Hashing.SearchProperlyHashedObjects(properlyHashedObjects));

// 7. HashSet vs SortedSet

// Console.WriteLine();
// Console.WriteLine("7.1. HashSet vs SortedSet. Creation speed");
// var   hashSet = MeasuringUtilities.MeasureTime(Sorted.Add.ToHashSet);
// var sortedSet = MeasuringUtilities.MeasureTime(Sorted.Add.ToSortedSet);
//
// Console.WriteLine();
// Console.WriteLine("7.2. HashSet vs SortedSet. Search speed");
// MeasuringUtilities.MeasureTime(() => Sorted.Contains.InHashSet(hashSet));
// MeasuringUtilities.MeasureTime(() => Sorted.Contains.InSortedSet(sortedSet));
//
// Console.WriteLine();
// Console.WriteLine("7.3. HashSet vs SortedSet. Memory");
// MeasuringUtilities.MeasureMemory(() => Sorted.Add.ToHashSet());
// MeasuringUtilities.MeasureMemory(() => Sorted.Add.ToSortedSet());

// 8. SortedSet vs Array

// var randomNumbers = Sorted.SetVsArray.GetRandomNumbers();
//
// Console.WriteLine();
// Console.WriteLine("8.1. SortedSet vs Array. Creation speed");
// var sortedArray = MeasuringUtilities.MeasureTime(() => Sorted.SetVsArray.CreateSortedArray(randomNumbers));
// var sortedSet   = MeasuringUtilities.MeasureTime(() => Sorted.SetVsArray.CreateSortedSet(randomNumbers));
//
// Console.WriteLine();
// Console.WriteLine("8.2. SortedSet vs Array. Search speed");
// MeasuringUtilities.MeasureTime(() => Sorted.SetVsArray.SearchInArray(sortedArray));
// MeasuringUtilities.MeasureTime(() => Sorted.SetVsArray.SearchInSet(sortedSet));
//
// Console.WriteLine();
// Console.WriteLine("8.3. SortedSet vs Array. Memory");
// MeasuringUtilities.MeasureMemory(() => Sorted.SetVsArray.CreateSortedArray(randomNumbers));
// MeasuringUtilities.MeasureMemory(() => Sorted.SetVsArray.CreateSortedSet(randomNumbers));

// 9. Concurrent creation

// var result = Concurrent.ArrayList.Add();

// 10. Concurrent creation with locks

// var result = Concurrent.ArrayList.AddWithLock();
// Console.WriteLine();
// Console.WriteLine($"{result.Count:N0} elements successfully added to the array list");

// 11. Locks vs ConcurrentBag

// Console.WriteLine();
// Console.WriteLine("11. Locks vs ConcurrentBag");
// MeasuringUtilities.MeasureTime(Concurrent.ArrayList.AddWithLock);
// MeasuringUtilities.MeasureTime(Concurrent.Bag.Add);
