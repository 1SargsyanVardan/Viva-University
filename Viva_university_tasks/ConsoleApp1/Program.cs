using ConsoleApp1;
using System.Text.Json;

//------------------TASK 1-----------------------
/*string str = "barrev hayastan";
Console.WriteLine(str.StringManipulation());*/

//------------------TASK 2-----------------------
/*List<Person> myList = new List<Person>();
Console.Write("Please input quantity of persons: ");
int numberOfPersons = int.Parse(Console.ReadLine());
//before sorted
for (int i = 0; i < numberOfPersons; i++)
{
    Person person = new Person();
    myList.Add(person);
}
//after sorted
//myList.Sort(); //inthernet versia
List<Person> sortedList = myList.SortedByProperty();
foreach (Person person in sortedList)
{
    Console.WriteLine($"{person.Name} is {person.Age} years old.");
}*/

//------------------TASK 3-----------------------
/*
DateTime now = DateTime.Now;
Console.WriteLine(now.ToFriendlyDate());*/

//------------------TASK 4-----------------------

/*string email = "vardan.sargsyan.772001@mail.com";
Console.WriteLine(email.IsValidEmail());*/

//------------------TASK 5-----------------------

/*string str = "                     hello World!    ";
Console.WriteLine(str.Trim());*/

//------------------TASK 6-----------------------


//------------------TASK 7-----------------------

/*double number = 6.1255468;
Console.WriteLine(number.MyRound(2));*/

//------------------TASK 8-----------------------
//haskacel em bayc chisht chi ashxatum!!!!!!!!!!!!!!!!!!!!!!!!
/*string filePath = "C:/Users/User/OneDrive/Рабочий стол/ConsoleApp1/ConsoleApp2/ConsoleApp2";
bool exists = filePath.FileExists();

if (exists)
    Console.WriteLine("File exists!");
else
    Console.WriteLine("File does not exist.");*/

//------------------TASK 9-----------------------

/*string str = "Green";
Colors color = str.ToEnum<Colors>();
Console.WriteLine(color);
public enum Colors
{
    Red,
    Green,
    Blue
};*/

//------------------TASK 12-----------------------
/*
List<Sms> smsMessiges = new List<Sms>
{
    new Sms("ID: 1788","Viva-MTS","Shnorhavorum enq, duq haxtel eq victorinan!"),
    new Sms("ID: 8568","Beeline","Shnorhavorum enq, duq haxtel eq victorinan!"),
    new Sms("ID: 7858","Viva-MTS","Dzer hashvi mnacordy kazmum e 1000 dr."),
    new Sms("ID: 1858","Viva-MTS","Shnorhavorum enq, duq darcel eq mer premium hachaxordy!")
};

var filteredByKeywordSms = smsMessiges.FilterByKeyword("Shnorhavorum enq");
foreach (var sms in filteredByKeywordSms)
    sms.AllData();
Console.WriteLine(new string('-',100));
var filteredSenderSms = smsMessiges.FilterBySender("Viva-MTS");
foreach (var sms in filteredSenderSms)
    sms.AllData();*/

//------------------TASK 13-----------------------

string number = "37494831910";
string newNumber = number.FormatPhoneNumber();
Console.WriteLine(newNumber);