using System;

public class Book
{
	public Book(string title, string author, string genre, int pages)
	{
		this.title = title;
		this.author = author;
		this.genre = genre;
		this.pages = pages;
	}
	string title;
	string author;
	string genre;
	int pages;

    bool isAvailable = true;

	public string Rent()
	{
		if (this.isAvailable == true)
		{
			this.isAvailable = false;
			return $"{this.title} was availabe, the rent was successful!";
		}
		else
		{
			return $"We're sorry, {this.title} is not available.";
		}

	}
	public void Return()
	{
		this.isAvailable = true;
	}
}
