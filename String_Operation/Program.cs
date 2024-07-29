#region Length
string str="Monkey D.Luffy";
int lengthOfString=str.Length;

System.Console.WriteLine("Length Of The String is-:"+lengthOfString);
#endregion

#region Substring
string str1="Hello My Name is Ichigo Kurosaki";

string subset1=str1.Substring(5);
string subset2=str1.Substring(6,17);
System.Console.WriteLine(subset2);
System.Console.WriteLine(subset1);

#endregion

#region IndexOf And LastIndexOf

string str2="Hello My Name is Ichigo Kurosaki";
System.Console.WriteLine(str2.LastIndexOf('k'));
System.Console.WriteLine(str2.IndexOf('i'));
    
#endregion

#region Upper And Lower Case
   string str4 = "Hello World";
        string lower = str4.ToLower();
        string upper = str4.ToUpper();
        
        Console.WriteLine(upper);
        Console.WriteLine(lower);
#endregion