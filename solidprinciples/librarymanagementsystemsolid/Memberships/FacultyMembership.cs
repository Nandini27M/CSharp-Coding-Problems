using System;

public class FacultyMembership
{
    public string FacultyName { get; set; }

    public FacultyMembership(string facultyName)
    {
        FacultyName = facultyName;
    }

    public void Display()
    {
        Console.WriteLine($"Faculty Member: {FacultyName}");
    }
}