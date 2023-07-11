using System;

public class Farm
{
	public Farm(string name, double area, int animalCount)
	{
		this.name = name;
		this.area = area;
		this.animalCount = animalCount;
	}

	public string name;
	public double area;
	public int animalCount;

	public void Addanimals(int amount)
	{
		this.animalCount = this.animalCount + amount; 
	}
	public double CalculateDensity()
	{
		return this.animalCount / this.area;
	}
}
