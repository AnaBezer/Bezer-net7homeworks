using System;

public class Book1
{
	public Book1(string title, string author, int year)
	{
		this.title = title;
		this.author = author;
		this.year = year;
	}

	private string title;
    private string author;
    private int year;

	public string GetTitle()
	{
		return this.title;
	}

	public string GetAuthor()
	{
		return this.author;
	}
	public int GetYear()
	{
		return this.year;
	}

	public string SetTitle(string newTitle)
	{
		return this.title = newTitle;
	}

	public string SetAuthor(string newAuthor)
	{
		return this.author = newAuthor;
	}

	public int SetYear(int newYear)
	{
		return this.year = newYear;
	}
}
