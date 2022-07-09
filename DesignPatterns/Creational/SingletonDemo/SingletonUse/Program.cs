// See https://aka.ms/new-console-template for more information
using SingletonUse;

var fromTeacher = Person.GetInstance;
fromTeacher.PrintPerson("Teacher created");

var fromStudent = Person.GetInstance;
fromStudent.PrintPerson("Student created");

Parallel.Invoke(
    () => PrintTeacher(),
    () => PrintTeacher()
);


static void PrintStudent()
{
    var fromStudent = Person.GetInstance;
    fromStudent.PrintPerson("Student created");
}

static void PrintTeacher()
{
    var fromTeacher = Person.GetInstance;
    fromTeacher.PrintPerson("Teacher created");
}