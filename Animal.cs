using System;
using System.Drawing;

public class Animal
{
	public Animal(string name, string species, string breed, int age, string color, double weight, bool isSpayedOrNeutered)
	{
		this.name = name;
		this.species = species;
		this.breed = breed;
		this.age = age;
		this.color = color;
		this.weight = weight;
		this.isSpayedOrNeutered = isSpayedOrNeutered;
	}

	private string name;
	private string species;
	private string breed;
	private int age;
	private string color;
	private double weight;
	private bool isSpayedOrNeutered;

	public string GetName()
	{
		return this.name;
	}

	public string GetSpecies()
	{
		return this.species;
	}

	public string GetBreed()
	{
		return this.breed;
	}

	public int GetAge()
	{
		return this.age;
	}

	public string GetColor()
	{
		return this.color;
	}

	public double GetWeight()
	{
		return this.weight;
	}

	public bool GetIsSpayedOrNeutered()
	{
		return this.isSpayedOrNeutered;
	}

	public string SetName(string newName)
	{
		return this.name = newName;
	}

	public string SetSpecies(string newSpecies)
	{
		return this.species = newSpecies;
	}

	public string SetBreed(string newBreed)
	{
		return this.breed = newBreed;
	}

	public int SetAge(int newAge)
	{
		return this.age = newAge;
	}

	public string SetColor(string newColor)
	{
		return this.color = newColor;
	}

	public double SetWeight(double newWeight)
	{
		return this.weight = newWeight;
	}

	public bool SetIsSpayedOrNeutered(bool isNeutered)
	{
		return this.isSpayedOrNeutered = isNeutered;
    }
}



