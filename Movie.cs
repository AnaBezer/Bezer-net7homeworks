using System;
using System.Security.Cryptography.X509Certificates;

public class Movie
{
    public Movie(string title, DateOnly publicationDate, string genre, string director, TimeSpan duration)
    {
        this.title = title;
        this.publicationDate = publicationDate;
        this.genre = genre; 
        this.director = director;
        this.duration = duration;
    }

    public string title;
    public DateOnly publicationDate;
    public string genre;
    public string director;
    public TimeSpan duration;

    public string GenerateAddvertisment()
    {
       return $"Welcome to {title} by {director}, an exceptional movie in the {genre} genre!";     
    }
}
