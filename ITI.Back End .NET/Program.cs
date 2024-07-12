// See https://aka.ms/new-console-template for more information

// Task 1

Console.Write("Enter Your Number: ");
int a = int.Parse(Console.ReadLine());
for (int i = 1; i < 13; i++)
{
    Console.WriteLine($"{i} * {a} = {i * a}");
}


//// TASK 2

Console.Write("Enter Your Name: ");
string Name = Console.ReadLine();


Console.Write("Enter Your phone: ");
string phone = Console.ReadLine();



Console.Write("Enter Your Age: ");
int Age = int.Parse(Console.ReadLine());

while( Age < 0 )
{
    Console.WriteLine("It Is A Vaild Age, Enter Age again ");
     Age = int.Parse(Console.ReadLine());


}
Console.WriteLine($"{Name} your age {Age} and Phone {phone}");



// Task 3
class Student
{
    int age;
    string name;
    string phone;
    int SSN;

    public void getData(int Age; string Name; string Phone;int ssn)
    {
        age = Age;
        name = Name; 
        phone = Phone; 
        SSN = ssn; 


    }
}

Student S1 = new Student(10;"Nour";"01068527251";555) ;
S1.getData();