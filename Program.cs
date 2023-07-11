
// Ex. 0

// Movie

using System;
using System.Diagnostics.Metrics;

Movie billyElliot = new Movie("Billy Elliot", new DateOnly(2000, 12, 20), "Dance/Drama", "Stephen Daldry", TimeSpan.FromMinutes(120));

Movie titanic = new Movie("Titanic", new DateOnly(1997, 12, 19), "Romance/Drama", "James Cameron", TimeSpan.FromMinutes(110));

Console.WriteLine(billyElliot.GenerateAddvertisment());

// Drug

Drug paracetamol = new Drug("Paracetamol", 25.50, 10, false);
Drug alprazolan = new Drug("Alprazolan", 50, 5, true);

Console.WriteLine("Initial quantity: "+ paracetamol.quantity);
Console.WriteLine(paracetamol.Sell(3));

Console.WriteLine(paracetamol.Sell(8));

Console.WriteLine(alprazolan.Sell(1));

// Book

Book theBigFour = new Book("The Big Four", "Agatha Christi", "Crime", 282);

Console.WriteLine(theBigFour.Rent());
Console.WriteLine(theBigFour.Rent());

theBigFour.Return();

Console.WriteLine(theBigFour.Rent());

// Ex. 1 

Crop tomato = new Crop("Tomato");
Console.WriteLine(tomato.TellTheCurrentStage());

tomato.Water();
Console.WriteLine(tomato.TellTheCurrentStage());

tomato.Water();
Console.WriteLine(tomato.TellTheCurrentStage());

tomato.Water();
Console.WriteLine(tomato.TellTheCurrentStage());

tomato.Harvest();
Console.WriteLine(tomato.TellTheCurrentStage());

// Ex. 2 

Farm horse = new Farm("Horse", 5000, 10);

Console.WriteLine(horse.animalCount);

horse.Addanimals(2);
Console.WriteLine(horse.animalCount);

Console.WriteLine(horse.CalculateDensity());

// Ex. 3 

Book1 book = new Book1("War and Peace", "Leo Tolstoy", 1869);

Console.WriteLine(book.GetTitle());
Console.WriteLine(book.GetAuthor());
Console.WriteLine(book.GetYear());

book.SetTitle("Ana Karenina");
book.SetAuthor("Leo Tolstoy");
book.SetYear(1877);

Console.WriteLine(book.GetTitle());
Console.WriteLine(book.GetAuthor());
Console.WriteLine(book.GetYear());

// Ex. 4 

Product product = new Product("Apple", 0.99, 10);

Console.WriteLine(product.GetName());
Console.WriteLine(product.GetPrice());
Console.WriteLine(product.GetQuantity());

product.SetName("Orange");
product.SetPrice(1.49);
product.SetQuantity(20);

Console.WriteLine(product.GetName());
Console.WriteLine(product.GetPrice());
Console.WriteLine(product.GetQuantity());

// Ex. 5 

Animal animal = new Animal("Max", "Dog", "Labrador Retriever", 2, "Yellow", 75, true);

Console.WriteLine(animal.GetName());
Console.WriteLine(animal.GetSpecies());
Console.WriteLine(animal.GetBreed());
Console.WriteLine(animal.GetAge());
Console.WriteLine(animal.GetColor());
Console.WriteLine(animal.GetWeight());
Console.WriteLine(animal.GetIsSpayedOrNeutered());

animal.SetName("Buddy");
animal.SetSpecies("Cat");
animal.SetBreed("Siamese");
animal.SetAge(5);
animal.SetColor("Gray");
animal.SetWeight(12);
animal.SetIsSpayedOrNeutered(false);

Console.WriteLine(animal.GetName());
Console.WriteLine(animal.GetSpecies());
Console.WriteLine(animal.GetBreed());
Console.WriteLine(animal.GetAge());
Console.WriteLine(animal.GetColor());
Console.WriteLine(animal.GetWeight());
Console.WriteLine(animal.GetIsSpayedOrNeutered());

// Ex. 6 

Calculator calculator = new Calculator();

Console.WriteLine(calculator.Add(2, 3));
Console.WriteLine(calculator.Subtract(5, 2));
Console.WriteLine(calculator.Multiply(3, 4));
Console.WriteLine(calculator.Divide(10, 5));
Console.WriteLine(calculator.Power(2,3));
Console.WriteLine(calculator.SquareRoot(9));

// Ex. 7 

University myUniversity = new University("My University");

Student john = new Student("John", "Doe", 123456, 3.8);
Student jane = new Student("Jane", "Smith", 654321, 3.6);

myUniversity.AddStudent(john);
myUniversity.AddStudent(jane);

Faculty mary = new Faculty("Mary", "Jones", 111111, new List<string> {"Math", "Physics"});
Faculty bob = new Faculty("Bob", "Smith", 222222, new List<string> {"English", "History"});

myUniversity.AddFaculty(mary);
myUniversity.AddFaculty(bob);

Console.WriteLine(myUniversity.GetStudentCount()); 
Console.WriteLine(myUniversity.GetFacultyCount());

// Ex. 8 

College collegeUSM = new College();

Student2 studentMaria = new Student2("Maria", new DateOnly(2020, 9, 1), new DateOnly(2023, 9, 1), collegeUSM, new DateOnly(2000, 10, 20));

Console.WriteLine(studentMaria.IsStillStudent());
Console.WriteLine(studentMaria.GetAge());



