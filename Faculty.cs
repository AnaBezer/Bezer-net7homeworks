using System;

public class Faculty
{
	public Faculty(string firstName, string lastName, int eployeeID, List<string> subjectsThaught)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.eployeeID = eployeeID;
		this.subjectsThaught = subjectsThaught;

    }

	private string firstName;
	private string lastName;
	private int eployeeID;
	private List<string> subjectsThaught;

    public string GetFullName()
	{
		return this.firstName + this.lastName;
	}

	public List<string> GetSubjectsTaught()
	{
		return this.subjectsThaught;
	}
}
