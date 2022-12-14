﻿// See https://aka.ms/new-console-template for more information
//My first program on c#
//Console.WriteLine("Hello, World! It`s my first code C#");


//My second program on c#
//Console.WriteLine("Input Your name: ");
//string username = Console.ReadLine();
//Console.WriteLine("Hello, "+username+"!");
//Console.WriteLine(username);

/*My third program on c#
int numberA = 3;
int numberB = 5;
int result = numberA*numberB;

Console.WriteLine(numberA+" + "+numberB+" = "+(numberA+numberB));
Console.WriteLine(numberA+" * "+numberB + " = "+result);
*/

/*My 4th program on c#
double numberA = 12;
double numberB = 5;
Console.WriteLine(numberA/numberB);
*/

//My 5th program on c#
/*
int numberA = new Random().Next(1,10);
int numberB = new Random().Next(1,10);

int result = numberA*numberB;

Console.WriteLine(numberA+" + "+numberB+" = "+(numberA+numberB));
Console.WriteLine(numberA+" * "+numberB + " = "+result);
*/
// My 5th programm
/*
Console.Write("Input your username: ");

string username = Console.ReadLine();

if (username.ToLower() == "maria") 
    {
    Console.WriteLine("Huray! Maria is here!!!");
    }
    else 
    {
    Console.WriteLine("Hello, "+username+"!");
    }  
*/

// My 6th programm
/*
int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if ( a > max ) max = a;
if ( b > max ) max = b;
if ( c > max ) max = c;
if ( d > max ) max = d;
if ( e > max ) max = e;

Console.WriteLine("max = "+max);
*/

Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");

int xa = 40, ya = 1, 
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");


Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");


Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;
while( count < 10000 )
{
    int what = new Random().Next(0, 3);
    if (what == 0 )
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }

    if (what == 1 )
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
    
    if (what == 2 )
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;
}