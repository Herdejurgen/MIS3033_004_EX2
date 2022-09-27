// MIS 3033 004 Exercise
// Jack Herdejurgen 113436899

// add xinglong.ju@ou.edu as the collaborator on GitHub
// 

//****************************************************
//Options Menu
//1. Add a new student's information
//2.Show all the students' information
//3. Show the student's information with smallest age
//4. Show the average weight of all the students
//Press other keys to exit.
//****************************************************

//Enter your option: 

//Add a new student
//Enter the ID: 
//Enter the name: 
//Enter the age: 
//Enter the weight:
using MIS3033_004_EX2;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

string userinput = "";
do
{
    Menu();
    if (userinput == "1")
    {
        Option1();
    }
    else if (userinput == "2")
    {
        Option2();
    }
    else if (userinput == "3")
    {
        Option3();
    }
    else if (userinput == "4")
    {
        Option4();
    }
} 
while (userinput == "1" || userinput == "2" || userinput == "3" || userinput == "4");


void Menu()
{
    Console.WriteLine("1. Add new student's information");
    Console.WriteLine("2. Show all students' information");
    Console.WriteLine("3. Show the student's information with the smallest age");
    Console.WriteLine("4. Show the average weight of all the students");
    Console.WriteLine("Press other keys to exit.");
    userinput = Console.ReadLine();
}
void Option1()
{
    Console.WriteLine("Add the new student:");
    Console.Write("ID: ");
    string ID = Console.ReadLine();
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Age: ");
    int age = Convert.ToInt16(Console.ReadLine());
    Console.Write("Weight: ");
    double weight = Convert.ToDouble(Console.ReadLine());
    Student stu = new Student(ID, name, age, weight);
    Student.stulist.Add(stu);
}
void Option2()
{
    foreach(Student stu in Student.stulist)
    {
        Console.WriteLine(stu);
    }
}
void Option3()
{
    Student lowestage = Student.stulist[0];
    int minage = Student.stulist[0].age;
    foreach(Student stu in Student.stulist)
    {
        if (stu.age < minage)
        {
            minage = stu.age;
            lowestage = stu;
        }
    }
    Console.WriteLine(lowestage);
}
void Option4()
{
    double sum = 0;
    int count = 0;
    foreach(Student stu in Student.stulist)
    {
        sum += stu.weight;
        count++;
    }
    double average = sum / count;
    Console.WriteLine($"Average weight: {average}");
}