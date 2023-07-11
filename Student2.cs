using System;

public class Student2
{
    public Student2(string name, DateOnly startDate, DateOnly endDate, College college, DateOnly birthDate)
    {
        this.name = name;
        this.startDate = startDate;
        this.endDate = endDate;
        this.college = college;
        this.birthDate = birthDate;
    }
    
    private string name;
    private DateOnly startDate;
    private DateOnly endDate;
    private College college;
    private DateOnly birthDate;

    public bool IsStillStudent()
    {
        DateTime today = DateTime.Today;

        if (this.endDate >= DateOnly.FromDateTime(today))
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public int GetAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year -  this.birthDate.Year;

        // Check if the birthday has occurred this year

        if (this.birthDate > DateOnly.FromDateTime(today.AddYears(-age)))
        {
            age--;
        }

        return age;
    } 

    public void Print()
    {
        Console.WriteLine(this.name);
        Console.WriteLine(this.endDate);
        Console.WriteLine(this.college);
        Console.WriteLine(this.birthDate);
        Console.WriteLine(this.IsStillStudent());
        Console.WriteLine(this.GetAge());
    }
}

