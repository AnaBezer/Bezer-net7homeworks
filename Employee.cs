using System;

public abstract class Employee
{
    public string email;
    public int phone;
    public string Name { get; set; }
	public int Age { get; set; }
	public double Salary { get; set; }

	public abstract double CalculateBonus();

	public virtual string GetContactInfo()
	{
		return $"No contact information available.";
    }
}

public enum Department
{
    HR,
    IT,
    Sales,
	Marketing
}

public class Manager : Employee
{
	public Manager(string name, int age, double salary, Enum department, string email, int phone)
	{
		this.Name = name;
		this.Age = age;
		this.Salary = salary;
		this.Deparment = department;

		this.email = email;
		this.phone = phone;
	}

	private Enum Deparment { get; set; }

	public override double CalculateBonus()
	{
		return this.Salary * 0.1;
	}

    public override string GetContactInfo()
    {
		return $"Name: {this.Name}, Age: {this.Age}, Department: {this.Deparment}, Email: {this.email}, Phone: {this.phone}";
	}
}

public class Developer : Employee
{
	public Developer(string name, int age, double salary, List<string> skills, bool isJunior)
	{
		this.Name = name;
		this.Age = age;
		this.Salary = salary;
		this.isJunior = isJunior;

        List<string> Skills = new List<string>();
    }
	private string Skills { get; set; }
	private bool isJunior { get; set; }

	public override double CalculateBonus()
	{
		return this.Salary * 0.2;
	}

    public override string GetContactInfo()
    {
		return $"Name: {this.Name}, Age: {this.Age}, Skills: {this.Skills}, Email: {this.email}, Phone: {this.phone}";
    }
}