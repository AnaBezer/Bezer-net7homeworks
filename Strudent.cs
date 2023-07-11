using System;

public class Student
{
    public Student(string firstName, string lastName, int studentID, double gpa)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.studentID = studentID;
        this.gpa = gpa;
    }

	private string firstName;
    private string lastName;
    private int studentID;
    private double gpa;

    public string GetFullName()
    {
        return this.firstName + this.lastName;
    }

    public bool HasHonor(double gpa)
    { 
        if(this.gpa >= 3.5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
