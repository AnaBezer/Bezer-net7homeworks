

using Exceptions_LINQ.Ex._1;
using Exceptions_LINQ.Ex._10;
using Exceptions_LINQ.Ex._2;
using Exceptions_LINQ.Ex._3;
using Exceptions_LINQ.Ex._4;
using Exceptions_LINQ.Ex._5;
using Exceptions_LINQ.Ex._6;
using Exceptions_LINQ.Ex._9;


InvalidDateException.InvalidDateExceptionMethod();

BlankNameException.BlankNameExceptionMethod();

ExceptionsEx3.ExceptionsMethod();

FileException.FileExceptionMethod();

DateTimeUse.DateTimeMethod();

IntUse.IntMethod();

// Ex. 7

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int sumOfSquaresOfEvenNumbers = numbers.Where(x => x % 2 == 0)
                                       .Select(x => x * x)
                                       .Sum();

Console.WriteLine("Sum of squares of even numbers: " + sumOfSquaresOfEvenNumbers);


// Ex. 8

List<int> originalList = new List<int> { 1, 2, 3, 4, 5 };

List<int> squaresList = numbers.Select(n => n * n).ToList();

Console.WriteLine("Original List: " + string.Join(", ", originalList));
Console.WriteLine("Squares List: " + string.Join(", ", squaresList));



// Ex. 9

var students = new List<Student> {
            new Student { Name = "Alice", Grade = 'A'},
            new Student { Name = "Bob", Grade = 'B'},
            new Student { Name = "Charlie", Grade = 'A' },
            new Student { Name = "Dave", Grade = 'C' }
        };

var studentsWithGradeA = students.Where(s => s.Grade == 'A')
                                 .OrderByDescending(s => s.Name)
                                 .ToList();

Console.WriteLine("Students with Grade 'A' in descending order of names:");

foreach (var student in studentsWithGradeA)
{
    Console.WriteLine(student.Name);
}


// Ex. 10

var products = new List<Product> {
  new Product { Name = "Product 1", Category = "Category 1", Price = 10 },
  new Product { Name = "Product 2", Category = "Category 2", Price = 20 },
  new Product { Name = "Product 3", Category = "Category 1", Price = 15 },
  new Product { Name = "Product 4", Category = "Category 3", Price = 5 },
  new Product { Name = "Product 5", Category = "Category 3", Price = 5 }
};

var distinctCategoriesSorted = products.Select(p => p.Category)
                                       .Distinct()
                                       .OrderBy(p => p)
                                       .ToList();

Console.WriteLine("Distinct categories sorted by name:");

foreach (var category in distinctCategoriesSorted)
{
    Console.WriteLine(category);
}

var categoriesSortedByPriceAndName = products
            .OrderBy(p => p.Price)
            .ThenBy(p => p.Name)
            .Select(p => p.Category)
            .Distinct()
            .ToList();

Console.WriteLine("\nCategories sorted by price and name:");

foreach (var category in categoriesSortedByPriceAndName)
{
    Console.WriteLine(category);
}


// Ex. 11

var averagePricesByCategory = products.GroupBy(p => p.Category)
                                      .Select(g => new
                                      {
                                          Category = g.Key,
                                          AveragePrice = g.Average(p => p.Price)
                                      })
                                      .OrderByDescending(g => g.AveragePrice)
                                      .ToList();


Console.WriteLine("Categories sorted by average price in descending order:");

foreach (var category in averagePricesByCategory)
{
    Console.WriteLine($"{category.Category}: {category.AveragePrice:c2}");
}