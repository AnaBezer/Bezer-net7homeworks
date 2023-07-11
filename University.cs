using System;

public class University
{
    public University(string name)
    {
        this.name = name;
    }

	private string name;
    private List<Student> students = new List<Student>();
    private List<Faculty> faculties = new List<Faculty>();

    public void AddStudent(Student student)
    {
        this.students.Add(student);
    }

    public void AddFaculty(Faculty faculty)
    {
        this.faculties.Add(faculty);
    }
    public int GetStudentCount()
    {
        return this.students.Count();
    }

    public int GetFacultyCount()
    {
        return this.faculties.Count();
    }
}
