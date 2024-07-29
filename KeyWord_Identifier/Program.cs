#region Built In Types

// string firstName;
// string lastName;

// int age;

// int width;

// bool isAdult;

// string @string;
// @string="Naruto Uzumaki";
// System.Console.WriteLine(@string);

// string name;
// name="Ayanokji";

// System.Console.WriteLine(name);

// int age;
// age=30;
// System.Console.WriteLine(age);

bool isFormConplete=default;
//System.Console.WriteLine(isFormConplete);

//we cannot print value before assigning it.
#endregion

#region Integral Type
sbyte @sbyte=default;
byte @byte=default;

ushort @ushort=default;
short @short=default;

int @int=default;
uint @uint=default;

// System.Console.WriteLine(@uint);
// System.Console.WriteLine(@ushort);
// System.Console.WriteLine(@sbyte);
// System.Console.WriteLine(@byte);
// System.Console.WriteLine(@int);


#endregion

#region Floating Type
//we have to tell compiler that right side value is not double so we use f
float float1=12345.123f;
double double1=12345.12345;
decimal decimal1=123.2314m;
#endregion


#region String Referrence

string name=default;
System.Console.WriteLine(name);
string namesWithQuotes="\"Kurosaki\"";
System.Console.WriteLine(namesWithQuotes);

string path="C:\\folder\\file.txt";

//Verbatim string literal
string path2=@"C:\folder\file.txt";
 System.Console.WriteLine(path);
 System.Console.WriteLine(path2);

 string multiLineMessgae="""
This is line 1
This is line 2
This is line 3
""";
System.Console.WriteLine(multiLineMessgae);
#endregion


#region Value Type vs Referrence Type
int x=10;
int y=x;    


#endregion

#region Null Colescing Operator
string ab=null;
string result=ab??"Anant";
System.Console.WriteLine(result);
#endregion

#region Nullable Types
int? age=null;//Nullable Types

bool? hasBecomeAPirate;
hasBecomeAPirate=null;

if(hasBecomeAPirate.HasValue)
{
    if(hasBecomeAPirate==true)
    System.Console.WriteLine("Has Become a Pirate");
    else
    System.Console.WriteLine("Has Not Become a Pirate");
}
else
System.Console.WriteLine("Still Confused");

#endregion


#region Arrays
int[] arr=new int[10];
int j=1;
foreach (var i in arr)
{
    arr[i]=j++;
    System.Console.WriteLine(arr[i]);
}
#endregion
