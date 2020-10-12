using Dapper;
using Student_Management_System;
using Student_Management_System.Classes;
using System;
using System.Collections.Generic;

namespace Student_Management_System
{
    public class Degree
    {
        public string DegreeName { get; set; }
        public int DegreeId { get; set; }
        public int Years { get; set; }
    }
}


public class Course : Degree
{
    public string CourseName { get; set; }
    public int DurationMonths { get; set; }
    public object CourseDegree { get; internal set; }
}


public class Person : PersonRules
{
    public int id { get; set; }
    public string Surname { get; set; }
    public string DateofBirth { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string ForeName
    {
        get { return $"{FirstName[0]}{MiddleName[0]}"; }
    }
    public string FullName
    {
        get { return $" {ForeName} {Surname}"; }
    }

    public string DegreeName { get; set; }
}

public class Student : PersonRules
{
    public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Surname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string DateofBirth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string MiddleName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string DegreeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public object StudentDegree { get; internal set; }
}

public class Lecturer : PersonRules
{
    public int id { get; set; }
    public string Surname { get; set; }
    public string DateofBirth { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string ForeName
    {
        get { return $"{FirstName[0]}{MiddleName[0]}"; }
    }
    public string FullName
    {
        get { return $" {ForeName} {Surname}"; }
    }
    public string DegreeName { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        string DateofBirth = "03/05/1987";

        DateTime dt = Convert.ToDateTime(DateofBirth);


        var Degree = new List<Degree>() {
                new Degree(){ DegreeId = 1, DegreeName="Criminology", Years = 4},
                new Degree(){ DegreeId = 2, DegreeName="Accounting", Years = 3},
                new Degree(){ DegreeId = 3, DegreeName="Psychology", Years = 4},
                new Degree(){ DegreeId = 4, DegreeName="Computer Science", Years = 3}
            };

        var Course = new List<Course>() {
                new Course(){ CourseName = "Requirements", DurationMonths= 4},
                new Course(){ CourseName = "Expert Skills", DurationMonths= 4},
                new Course(){ CourseName = "Intro", DurationMonths= 4},
                new Course(){ CourseName = "Basics", DurationMonths= 4},
            };


        var Lecturer = new List<Lecturer>() {
                new Lecturer(){ id = 1, Surname="Meiring",DateofBirth = "03,05,1988",Email = "arnomeiring3@gmail.com", FirstName = "Arno",MiddleName="Steven",DegreeName= "Criminology" },
                new Lecturer(){ id = 2, Surname="McDonald",DateofBirth = "12,06,1963",Email = "whale3@gmail.com", FirstName = "Josh",DegreeName= "Accounting" },
                new Lecturer(){ id = 3, Surname="Kentucky",DateofBirth = "07,12,1958",Email = "pokkels@gmail.com", FirstName = "Pierce",DegreeName= "Psychology" },
                new Lecturer(){ id = 4, Surname="Navada",DateofBirth = "06,01,1972",Email = "aseany@gmail.com", FirstName = "Sean",MiddleName="Juan",DegreeName= "Computer Science"},

            };

        var Student = new List<Student>()
        {
            new Student() { id = 1, Surname = "Meiring", DateofBirth = "03,05,2000", Email = "arnomeiring3@gmail.com", FirstName = "Micheal", DegreeName = "Criminology" },
            new Student() { id = 2, Surname = "Meiring", DateofBirth = "03,05,2001", Email = "arnomeiring3@gmail.com", FirstName = "Jess", DegreeName = "Accounting" },
            new Student() { id = 3, Surname = "Meiring", DateofBirth = "03,05,2000", Email = "arnomeiring3@gmail.com", FirstName = "Andrew", MiddleName = "Peter", DegreeName = "Psychology" },
            new Student() { id = 4, Surname = "Meiring", DateofBirth = "03,05,2001", Email = "arnomeiring3@gmail.com", FirstName = "Maggie", DegreeName = "Computer Science" },

        };
    }


    private List<Student> students = new List<Student>();

    public bool Contains(Student student)
    {
        return this.students.Contains(student);
    }

    public void Add(Student student)
    {
        if (!Contains(student))
            this.students.Add(student);
        student.StudentDegree = this;
    }

    public void Remove(Student student)
    {
        if (Contains(student))
            this.students.Remove(student);


        if (student.StudentDegree != this)
            return;

        student.StudentDegree = null;
    }
    private List<Course> courses = new List<Course>();

    public bool Contains(Course course)
    {
        return this.courses.Contains(course);
    }

    public void Add(Course course)
    {
        if (!Contains(course))
            this.courses.Add(course);
        course.CourseDegree = this;
    }

    public void Remove(Course course)
    {
        if (Contains(course))
            this.courses.Remove(course);


        if (course.CourseDegree != this)
            return;

        course.CourseDegree = null;
    }
}




