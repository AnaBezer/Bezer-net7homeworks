using System;

public class Book
{
	public Book(string title, string author, int pageCount)
	{
		this.Title = title;
		this.Author = author;
		this.PageCount = pageCount;

        this.CurrentPage = 1;
    }
	public string Title { get; set; }
	public string Author { get; set; }
	private int PageCount { get; set; }
	private int CurrentPage { get; set; }

	public string GetTitle()
	{
		return this.Title;
	}

	public string GetAuthor()
	{
		return this.Author;
	}

	public int GetPageCount()
	{
		return this.PageCount;
	}

	public int GetCurrentPage()
	{
        return this.CurrentPage;
	}

	public int NextPage()
	{
		this.CurrentPage++;
		return this.CurrentPage;
	}

	public int PreviousPage()
	{
		this.CurrentPage--;
		return this.CurrentPage;
	}
}

