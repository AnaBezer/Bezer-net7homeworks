// See https://aka.ms/new-console-template for more information
using System;
using System.Net.NetworkInformation;

Console.WriteLine("Hello, World!");

// Ex. 1

Console.WriteLine("first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("second number: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("third number: ");
int thirdNumber = int.Parse(Console.ReadLine());

int minNum, maxNum;

// find minimum number

if (firstNumber <= secondNumber && firstNumber <= thirdNumber)
{
    minNum = firstNumber;

}
else if (secondNumber <= firstNumber && secondNumber <= thirdNumber)
{
    minNum = secondNumber;
}
else
{
    minNum = thirdNumber;
}

// find maximum number 

if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
{
    maxNum = firstNumber;

}
else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
{
    maxNum = secondNumber;
}
else
{
    maxNum = thirdNumber;
}

Console.WriteLine($"Minimum number is {minNum}");
Console.WriteLine($"Maximum number is {maxNum}");


// Ex. 2

Console.WriteLine("first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

// condition? statement 1 : statement 2

int mMin = (num1 < num2) 
    ? ((num1 < num3) ? num1 : num3)
    : ((num2 < num3) ? num2 : num3);

int mMax = ( num1 > num2)
    ? ((num1 > num3) ? num1 : num3)
    : ((num2 > num3) ? num2 : num3);

Console.WriteLine("Minimum number: " + mMin);
Console.WriteLine("Maximum number: " + mMax);


// Ex. 3

Console.WriteLine("Enter the number of days : ");
int totalDays = Convert.ToInt32(Console.ReadLine());

int years = totalDays / 356;
int months = (totalDays % 356) / 30;
int weeks = ((totalDays % 356) % 30 ) / 7;
int days = ((totalDays % 356) % 30) % 7;

string yearString = years == 1 ? "year" : "years";
string monthString = months == 1 ? "month" : "months";
string weekString = weeks == 1 ? " week" : "weeks";
string dayString = days == 1 ? "day" : "days";

string result = $"{years} {yearString}, {months} {monthString}, {weeks} {weekString}, {days} {dayString}";

Console.WriteLine(result);


// Ex. 4

Console.Write("Physics mark: ");
int physicMark = Convert.ToInt32(Console.ReadLine());

Console.Write("Chemistry mark:  ");
int chemistryMark = Convert.ToInt32(Console.ReadLine());

Console.Write("Biology mark: ");
int biologyMark = Convert.ToInt32(Console.ReadLine());

Console.Write("Mathematics mark: ");
int mathMark = Convert.ToInt32(Console.ReadLine());

Console.Write("Computer Science mark: ");
int csMark = Convert.ToInt32(Console.ReadLine());

int totalMarks = physicMark + chemistryMark + biologyMark + mathMark + csMark;

double percentage = (totalMarks / 500.0) * 100;
string grade;

if (percentage >= 90)
    grade = "A";
else if (percentage >= 80)
    grade = "B";
else if (percentage >= 70)
    grade = "C";
else if ( percentage >= 60)
    grade = "D";
else if (percentage >= 50)
    grade = "E";
else
    grade = "F";

Console.WriteLine("Percentage = {0:F2} and grade is {1}", percentage, grade);


// Ex. 5

Console.WriteLine("Enter the grade: ");
char Fgrade = Convert.ToChar(Console.ReadLine().ToUpper());

switch (Fgrade)
{
    case 'E':
        Console.WriteLine("Excellent");
        break;
    case 'V':
        Console.WriteLine("Very Good");
        break;
    case 'G':
        Console.WriteLine("Good");
        break;
    case 'A':
        Console.WriteLine("Average");
        break;
    case 'F':
        Console.WriteLine("Fail");
        break;
    default:
        Console.WriteLine("Invalid grade");
        break;
}


// Ex. 6

Console.WriteLine("Enter the temperature in Celsius: ");
int temperature = Convert.ToInt32(Console.ReadLine());

switch (temperature)
{
    case < 0:
        Console.WriteLine("Freezing weather");
        break;
    case <= 0 and < 10:
        Console.WriteLine("Very cold weather");
        break;
    case >= 10 and < 20:
        Console.WriteLine("Cold weather");
        break;
    case >= 20 and < 30:
        Console.WriteLine("Normal in temperature");
        break;
    case >= 30 and < 40:
        Console.WriteLine("It's hot");
        break;
    case >= 40:
        Console.WriteLine("It's very hot");
        break;
    default:
        Console.WriteLine("Invalid temperature");
        break;

}


int ana = 10;
int gicu = 9;
int dan = 8;

