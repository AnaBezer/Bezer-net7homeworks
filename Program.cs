// Ex. 1

// using for loop

int[] numbers = new int[] { 1, 2, 3, 4, 5 };
int sum = 0;

for (int counter = 0; counter <= 4; counter++)
{
    if (numbers[counter] % 2 == 0)
    {
        sum = sum + numbers[counter];
    }
}
Console.WriteLine("Value of the even numbers: " + sum);

// using foreach loop

sum = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sum = sum + number;
    }
}
Console.WriteLine("Value of the even numbers: " + sum);

// Ex. 2

int[] nr = new int[5] { 1, 2, 3, 3, 4 };
List<int> bagwithUniques = new List<int> { };

foreach (int number in nr)
{
    if (bagwithUniques.Contains(number))
    {
        Console.WriteLine("Duplicated number: " + number);
    }
    else
    {
        bagwithUniques.Add(number);
    }

}


// Ex. 3

List<string> initialList = new List<string> { "a", "b", "b", "c", "c", "d" };
List<string> uniqueElementList = new List<string>();
List<string> iterationList = new List<string>(initialList);

foreach (string element in iterationList)
{
    if (!uniqueElementList.Contains(element))
    {
        uniqueElementList.Add(element);
    }
    else
    {
        initialList.Remove(element);
    }
}

foreach (string element in initialList)
{
    Console.Write(element + " ");
}

Console.WriteLine();

// Ex. 4 

int[] initialArray = new int[9] { 1, 4, 5, 2, 1, 4, 3, 1, 2 };

Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();

for (int counter = 0; counter <= 8; counter++)
{
    if (!frequencyDictionary.ContainsKey(initialArray[counter]))
    {
        frequencyDictionary.Add(initialArray[counter], initialArray.Count(e => e == initialArray[counter]));
    }
}

foreach (KeyValuePair<int, int> pair in frequencyDictionary)
{
    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
}


// Ex. 5 

int[] evenNumbers = new int[6];
int[] oddNumbers = new int[6];

for (int counter = 0; counter <= 5; counter++)
{
    Console.WriteLine("Enter numbers: ");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    if (userNumber % 2 == 0)
    {
        evenNumbers[counter] = userNumber;
    }
    else
    {
        oddNumbers[counter] = userNumber;
    }
}


// Ex. 6

Console.WriteLine("Enter a number : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b number: ");
int b = Convert.ToInt32(Console.ReadLine());

List<int> list = new List<int>();


if (a < b)
{
    for (int counter = a; counter <= b; counter++)
    {
        list.Add(counter);
        Console.WriteLine(counter);
    }
}
else
{
    for (int counter = b; counter <= a; counter++)
    {
        list.Add(counter);
        Console.WriteLine(counter);
    }
}


foreach (int number in list)
{
    if (number % 3 == 0)
    {
        Console.WriteLine(number);
    }
}

// Ex. 7

List<int> fizzBuzzList = new List<int>();

for (int counter = 123; counter <= 234; counter++)
{
    fizzBuzzList.Add(counter);
    Console.WriteLine(counter);
}

foreach (int number in fizzBuzzList)
{
    if ((number % 3 == 0) && (number % 5 == 0))
    {
        Console.WriteLine(number + " FizzBuzz");
    }
    else if (number % 3 == 0)
    {
        Console.WriteLine(number + " Fizz");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine(number + " Buzz");
    }
    else
    {
        Console.WriteLine(number);
    }
}


// Ex. 8 

List<string> namesList = new List<string>();

for (int counter = 0; counter <= 10; counter++)
{
    Console.WriteLine("Enter a name: ");
    namesList.Add(Console.ReadLine());
}


int whileCounter = 0;

while (whileCounter <= 5)
{
    Console.WriteLine(namesList[whileCounter]);
    whileCounter++;
}


// Ex. 9

int userNr;

do
{
    Console.WriteLine("Enter a number: ");
    userNr = Convert.ToInt32(Console.ReadLine());

} while (userNr != 0);


// Ex. 10 

int iterationNumber = -123;

do
{
    Console.WriteLine(iterationNumber);
    if (iterationNumber % 21 == 0)
    {
        break;
    }
    iterationNumber++;
} while (iterationNumber <= -1);


// Ex. 11.

List<string> abNames = new List<string>();

int counter1 = 0;

while (counter1 <= 10)
{
    Console.WriteLine("Enter a name: ");
    abNames.Add(Console.ReadLine());
    counter1++;
}

foreach (string abName in abNames)
{
    if ((abName.StartsWith("A") || abName.StartsWith("a") || abName.StartsWith("B") || abName.StartsWith("b")))
    {
        continue;
    }
    Console.WriteLine(abName);
}
