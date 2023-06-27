// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Threading.Channels;

Console.WriteLine("Hello, World!");


// Ex. 2

int[,] matrix = new int[,]
{
    {123, 345, 567},
    {12, 56, -12 },
    {34, -98, 65 },
    {756, 543, 321}
};

int rows = matrix.GetLength(0);
int columns = matrix.GetLength(1);

int centerRowIndex = rows / 2;
int centerColumnIndex = columns / 2;

int centerElement1 = matrix[centerRowIndex, centerColumnIndex];
int centerElement2 = matrix[centerRowIndex - 1, centerColumnIndex];

Console.WriteLine("Center elements: {0}, {1}", centerElement1, centerElement2);


// Ex. 3

List<string> names = new List<string> { "Diana", "Bianca", "Adelina", "Gabriela" };

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

if (!names.Contains(name))
{
    names.Add(name);
}

Console.WriteLine("List of names:");
foreach (string n in names)
{
    Console.WriteLine(n);
}


// Ex. 4

Stack <int > myStack = new Stack<int>();

Console.WriteLine("Enter first number: ");
myStack.Push(Convert.ToInt32(Console.ReadLine())); 

Console.WriteLine("Enter second number: ");
myStack.Push(Convert.ToInt32(Console.ReadLine()));

if (myStack.ElementAt(0) == 30 || myStack.ElementAt(1) == 30)
{
    Console.WriteLine("True");
}
else if (myStack.ElementAt(0) + myStack.ElementAt(1) == 30)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}


// Ex. 5

Queue<int> myQueue = new Queue<int>();

Console.WriteLine("Enter first number: ");
myQueue.Enqueue(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Enter the second number: ");
myQueue.Enqueue(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Enter the third number: ");
myQueue.Enqueue(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Enter the fourth number: ");
myQueue.Enqueue(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Enter the fifth number: ");
myQueue.Enqueue(Convert.ToInt32(Console.ReadLine()));


if (!(myQueue.Peek() > 0 && (myQueue.Peek() % 3 == 0 || myQueue.Peek() % 7 == 0)))
{
    myQueue.Dequeue();
}

Console.WriteLine(myQueue.Peek());









