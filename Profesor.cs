using System;

public class Profesor
{
    public Profesor(string name, string faculty, string specialization)
    {
        this.name = name;
        this.faculty = faculty;
        this.specialization = specialization;
    }

    public Profesor(string name, string faculty, string specialization, List<Student> studentWhoGiveTheirDegree)
    {
        this.name = name;
        this.faculty = faculty;
        this.specialization = specialization;
        this.studentWhoGiveTheirDegree = studentWhoGiveTheirDegree;
    }

    public string name;
    public string faculty;
    public string specialization;
    public List<Student> studentWhoGiveTheirDegree;

}