using Generics.GenericExercises;
using static InterfaceRunner;


// Ex. 1

List<int> intList = new List<int> { 1, 2, 3, 4, 5 };

Runner.ReverseList(intList);

foreach (int i in intList)
{
    Console.WriteLine(i);
}

// Ex. 2

List<string> stringList = new List<string> { "Ana", "Maria", "Ioana", "Bogdana" };

List<string> sortedList = Runner.SortList(stringList);

foreach (string j in sortedList)
{
    Console.WriteLine(j);
}

// Ex. 3

QueueRunner<int> intQueue = new QueueRunner<int>();

intQueue.Enqueue(1);
intQueue.Enqueue(2);
intQueue.Enqueue(3);

Console.WriteLine($"Queue items: {intQueue}");

while (intQueue.Count > 0)
{
    Console.WriteLine(intQueue.Dequeue());
}


// Ex. 4, 6

List<string> urls = new List<string>
{
    "https://www.microsoft.com/",
    "https://www.apple.com/",
    "https://www.facebook.com/"
};

foreach (string url in urls)
{
    GetDataFromWebAsync.GetURL(url);
}


// Ex. 5

InterfaceRunner.IComparer<string> stringComparer = new StringLengthComparer();
int stringComparisonResult = stringComparer.Compare("apple", "banana");
Console.WriteLine("String comparison result: " + stringComparisonResult);


