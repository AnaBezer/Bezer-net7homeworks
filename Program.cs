


// EX. 1

using System;
using System.Drawing;

BankAccount myAccount = new BankAccount(123456, "John Doe", 1000);

myAccount.Deposit(500);
myAccount.Withdraw(200);

Console.WriteLine(myAccount.GetBalance()); // Outputs 1300

List<Transaction> transactions = myAccount.GetTransactionHistory();
foreach (Transaction transaction in transactions)
{
    Console.WriteLine($"{transaction.Timestamp}: {transaction.Type} ${transaction.Amount}");
}


// EX. 2

Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);

Console.WriteLine(book.GetTitle()); // Outputs "The Great Gatsby"
Console.WriteLine(book.GetAuthor()); // Outputs "F. Scott Fitzgerald"
Console.WriteLine(book.GetPageCount()); // Outputs 180
Console.WriteLine(book.GetCurrentPage()); // Outputs 1

book.NextPage();
Console.WriteLine(book.GetCurrentPage()); // Outputs 2

book.NextPage();
book.NextPage();
book.NextPage();
Console.WriteLine(book.GetCurrentPage()); // Outputs 5

book.PreviousPage();
Console.WriteLine(book.GetCurrentPage()); // Outputs 4

book.Title = "The Great Gatsby (Revised Edition)";
Console.WriteLine(book.GetTitle()); // Outputs "The Great Gatsby (Revised Edition)"

book.Author = "F. Scott Fitzgerald (Revised by Jane Doe)";
Console.WriteLine(book.GetAuthor()); // Outputs "F. Scott Fitzgerald (Revised by Jane Doe)"


// EX. 3

Rectangle rectangle1 = new Rectangle("Green", 6, 8);
Rectangle rectangle2 = new Rectangle("Yellow", 10, 12);

Circle circle1 = new Circle("Purple", 3);
Circle circle2 = new Circle("Orange", 5);

List<Shape> shapes = new List<Shape> { rectangle1, rectangle2, circle1, circle2 };

foreach (Shape shape in shapes)
{
    shape.CalculateArea();
}

shapes.Sort((shape1, shape2) => shape2.Area.CompareTo(shape1.Area));

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Color + ": " + shape.Area);
}

double totalPerimeter = 0;
foreach (Shape shape in shapes)
{
    totalPerimeter += shape.GetPerimeter();
}

Console.WriteLine("Total perimeter: " + totalPerimeter + " inches"); // Outputs "Total perimeter: 122,26548245744 inches"


// Ex. 4

Manager manager = new Manager("John Doe", 35, 50000, Department.IT, "john.d", 40758362);
Developer developer = new Developer("Jane Smith", 28, 30000, new List<string> { "C#", "JavaScript" }, false);

Console.WriteLine(manager.CalculateBonus()); // Outputs 5000
Console.WriteLine(developer.CalculateBonus()); // Outputs 6000

Console.WriteLine(manager.GetContactInfo()); // Outputs "Name: John Doe, Age: 35, Department: IT, Email: john.d


// EX. 5

BankAccount2 account1 = new BankAccount2(123456, "John Doe", 1000);
BankAccount2 account2 = new BankAccount2(654321, "Jane Smith", 2000);

account1.Deposit(500);
account2.Withdraw(1000);

Console.WriteLine(account1.Balance); // Outputs 1500
Console.WriteLine(account2.Balance); // Outputs 1000

Console.WriteLine(account1.GetInterest()); // Outputs 15
Console.WriteLine(account2.GetInterest()); // Outputs 20

Console.WriteLine(Bank.NumAccounts); // Outputs 2


// EX. 6


IShape circle = new Circle1(5);
IShape rectangle = new Rectangle1(10, 5);

Console.WriteLine(circle.CalculateArea()); // Outputs 78.5398163397448
Console.WriteLine(rectangle.CalculateArea()); // Outputs 50

Console.WriteLine(circle.CalculateArea("square feet")); // Outputs "Area: 78.5398163397448 square feet"
Console.WriteLine(rectangle.CalculateArea("square meters")); // Outputs "Area: 50 square meters";

IColor circleColor = (IColor)circle;
circleColor.Color = "Red";

IColor rectangleColor = (IColor)rectangle;
rectangleColor.Color = "Blue";

Console.WriteLine(circleColor.Color); // Outputs "Red"
Console.WriteLine(rectangleColor.Color); // Outputs "Blue"


