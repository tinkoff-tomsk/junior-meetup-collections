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