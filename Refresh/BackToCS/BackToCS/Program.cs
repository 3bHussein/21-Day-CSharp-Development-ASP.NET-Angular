﻿// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, Hussein!");
//Console.ForegroundColor = ConsoleColor.White;
//Console.BackgroundColor = ConsoleColor.Cyan;

//Defind variable 
string name;

//declear single variable 
//int num1; int num2= 1; int num3;

//Declear multi variables in one line :)
int num1, num3, num2 = 1;
//this one for more 16 digit
long bignumber = 123123123123123123;


float total;
//to make machine accept float Div /* put f in end of number
//example
float total1 = 43.24f;
//same for float
double bigfloat_number;

char sym;
bool vote= true;



string name1 = "ahmed";
string v = name1.ToUpper();


Console.WriteLine($"your name {v}");



//Best Way to concat string with Variable :)
Console.WriteLine($"num2 {num2}");

Console.WriteLine("please enter your num :)");
try
{
    num3 = Convert.ToInt16(Console.ReadLine());
    num3.ToString();
    string total_num = "tot" + num3;
    Console.WriteLine(total_num);
    Console.WriteLine($"your number is {num3}");

}

catch
{
    Console.WriteLine("error while add number");
}

//that i back to write code using c# 



Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.Red;





//Console.ReadKey();


/*
public enum Docking
{
    none = 0,
    top = 1,
    buttom = 2,
    left = 3,
    right = 4
}

string docking = Docking.top.ToString();

Console.WriteLine(docking);



//test old class in .net3,5
class CityPlace
{

    string _car;  //accespeted// /**/




//Console.WriteLine("hello");


//string 3cat; //wrong variable
//    public static string adda(string arg)
//    {

//        return null;
//    }

// pulbic static int 
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("hello");
//    }
//}

//another way to concat

//Console.WriteLine("your number is "+num3);



//Coding Standards redone 2021
/*
 *Reasonable Variable Name  
 * int age=25;
 * String userAge="ahmed";
 * 
 * Proper Method Name 
 * void checkinternet(){
 * //your code 
 * }
 * Comments 
 * //this comment
 */


// Test   Types Float ,Double ,int ,bool aslo Convert

double Db_Number=4;

int in_Number;
in_Number = (int)Db_Number;

in_Number.ToString();

bool IsOn=true;
float Fl_Number = 13.74F;

string MyBoolString = IsOn.ToString();


string St_Num = "54";
int Num_F_ST = Int16.Parse(St_Num);
Console.WriteLine(Num_F_ST);


string test = "hello";
string test1 = "john";
Console.WriteLine(string.Concat("",test,test1,"gg"), "\n", test1.ToUpper(),test1.Substring(2));
Console.WriteLine("this is breake \n ");

Console.WriteLine(test1.ToUpper());
Console.WriteLine(test1.Substring(2));

    //example for String Method 
    string firstName = "Denis";
    string lastName = "Panjuta";
    string fullName = string.Concat("", firstName, lastName, "");
    Console.WriteLine(firstName.Substring(2)); // output: “nis”
    Console.WriteLine(firstName.ToLower()); // output: “denis”
    Console.WriteLine(firstName.ToUpper()); // output: “DENIS”
    Console.WriteLine(fullName.Trim()); // output: “DenisPanjuta”
    Console.WriteLine(firstName.IndexOf('e')); // output: 1




string MyName;
Console.WriteLine("Please Enter your Name: ? \n");
MyName = Console.ReadLine().ToUpper();
Console.WriteLine($"your name is :{MyName}");
MyName.Trim();
Console.WriteLine($"your name with Trim{MyName}");

Console.WriteLine(MyName.IndexOf('1'));

// create Constants Feild
const float PI = 3.1415F;


// create void method and normal method
// void method this one have stiace back without "return";
// non void it's return Value ;
void WriteSomeTing()
{
    Console.WriteLine("hello world ");
}

WriteSomeTing();

int addx(int x,int y)
{
    int total = x + y;
    return total;
}
int num32, num4;

Console.WriteLine("Please enter two number to Count ");
Console.WriteLine("please enter the firest number");
num32 = Int32.Parse(Console.ReadLine());
Console.WriteLine("please enter the second number");
num4 = Int32.Parse(Console.ReadLine());
Console.Write("the total will be ");
Console.WriteLine(addx(num32, num4)); 

    //There Tree Ways to Write With Console
    //1.
    Console.WriteLine("hello "+St_Num);

//
//2.
Console.WriteLine("Hello with second way {0}",St_Num);
//
//3.
Console.WriteLine($"this one thried way for write with Console {St_Num}");
//
//End of Documentation

Console.WriteLine($"Hello from here with convert from double number to int number {Fl_Number}{MyBoolString}");

Console.ReadLine();











//Refresh 
//static int add(int x)
//{
//    return null;
//}




//Day 1
//class people
//{
//    private string name;
//    private int age;


//    private static string add(int x)
//    {
//        private int total = 0;
//    total= 

//        return age+;
//    }
//}

//class main
//{
//    public  string p1 =new people();

//}



//old .net
//namespace project;

//class program
//{
//    static void Main(string[] args)
//    {

//    }



//    static string add(int f)
//    {

//        private home1 =new home1();
//        return null;

//    }
//}