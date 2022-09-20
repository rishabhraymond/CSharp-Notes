using SimpleLazyLoading;

Parallel.Invoke(
    () => PrintTeacher(),
    () => PrintStudent()
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