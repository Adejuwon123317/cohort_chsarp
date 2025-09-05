// See https://aka.ms/new-console-template for more information
using cohort_csharp;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Threading.Channels;
List<Student> students = new List<Student>();
students.Add(new Student() { Id = 01, Name = "Juwon", Grade = 90, Age = 21, Class = "400level" });
students.Add(new Student() { Id = 02, Name = "Nathaniel", Grade = 65, Age = 19, Class = "200level" });
students.Add(new Student() { Id = 03, Name = "Gabriel", Grade = 70, Age = 20, Class = "300level" });
students.Add(new Student() { Id = 04, Name = "Isreal", Grade = 78, Age = 15, Class = "300level" });
students.Add(new Student() { Id = 05, Name = "Joseph", Grade = 74, Age = 17, Class = "100level" });
students.Add(new Student() { Id = 06, Name = "Tomiwa", Grade = 80, Age = 22, Class = "400level" });
students.Add(new Student() { Id = 07, Name = "Enoch", Grade = 75, Age = 21, Class = "400level" });
students.Add(new Student() { Id = 08, Name = "David", Grade = 65, Age = 21, Class = "300level" });
students.Add(new Student() { Id = 09, Name = "Praise", Grade = 55, Age = 13, Class = "100level" });
students.Add(new Student() { Id = 10, Name = "Peter", Grade = 77, Age = 18, Class = "400level" });

ispromoted word = new ispromoted(qualify);

Student.PromoteStudent(students, word);

static bool qualify(Student students)
{
    if (students.Grade >= 75)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//Console.WriteLine("Write a greeting message to send to your friend in uppercase");
//string word = Console.ReadLine();
//var result = word.ToLower();
//Console.WriteLine(result);

//Console.ReadKey();
//
