# What happens when we do not use Singleton
## Scenario
- We have a class called person which can create object of person for different scenarios.
- In `Program.cs` we instantiated `Person` in the following way:
```
var fromTeacher = new Person();
fromTeacher.PrintPerson("Teacher created");  

var fromStudent = new Person();
fromStudent.PrintPerson("Student created");
```
## Problem with this
- We created **2 instances** of the person class which has same functionalities but have different names (teacher and student). 
- So its unnecessary to create two objects of the same class.