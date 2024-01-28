using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Introduction;
public class MainClass
{
    public String Name { get; set; }

    public static void Print_Name(String Name)
    {
        Console.WriteLine($"Your Name is :: {Name}");
    }

    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    public static void Main(String[] args)
    {
        string stringVar = "Hello World!!";
        int intVar = 100;
        float floatVar = 10.2f;
        char charVar = 'A';
        bool boolVar = true;

        // C# 7.1 onwards
        int i = default; // 0
        float f = default;// 0
        decimal d = default;// 0
        bool b = default;// false
        char c = default;// '\0'

        Console.WriteLine($"_ {i} _ {f} _ {d} _ {b} _ {c} _");



        float k = 3274;
        int dkf = (int)k;
    }
















    //public static void Main(String[] Args)
    //{
    //    int num = 100;
    //    float rate = 10.2f;
    //    decimal amount = 100.50M;
    //    char code = 'C';
    //    bool isValid = true;
    //    string name = "Ebraehm";
    //    // const int i3 = Convert.ToInt32(Console.WriteLine());
    //    int i = 10, j = 20, k = 30;
    //    Console.WriteLine(i + j + k);

    //    // a = 10, b = 20
    //    int a = 10, b = 20;
    //    int temp = a;
    //    a = b;
    //    b = temp;
    //    Console.WriteLine($"Value Of a :: {a} Value Of b :: {b}");

    //    int i1 = 100;

    //    int j1 = i1 + 20; // j = 120

    //    i1 = 200;
    //    j1 = i1 + 20;// j = 220

    //    i1 = 300;
    //    Console.WriteLine($"j = {j1}");// j = 220

    //    //////////////////

    //    //Example: LINQ Query Syntax in C#
    //    // string collection
    //    IList<string> stringList = new List<string>() {
    //        "C# Tutorials",
    //        "VB.NET Tutorials",
    //        "Learn C++",
    //        "MVC Tutorials" ,
    //        "Java"
    //    };

    //    // LINQ Query Syntax
    //    var result = from s in stringList
    //                 where s.Contains("Tutorials")
    //                 select s;




    //    ICollection<String> MyList = new List<String>()
    //    {
    //        "C# Tutorials",
    //        "VB.NET Tutorials",
    //        "Learn C++",
    //        "MVC Tutorials",
    //        "Java"
    //    };

    //    // LINQ Query Syntax
    //    var Myresult = from c in MyList
    //                 where c.Contains("Learn C++")
    //                 select c;
    //}






    //public static void Main(string[] args)
    //{
    //    var i = 10;
    //    Console.WriteLine("Type of i is {0}", i.GetType());

    //    var str = "Hello World!!";
    //    Console.WriteLine("Type of str is {0}", str.GetType());

    //    var dbl = 100.50d;
    //    Console.WriteLine("Type of dbl is {0}", dbl.GetType());

    //    var isValid = true;
    //    Console.WriteLine("Type of isValid is {0}", isValid.GetType());

    //    var ano = new { name = "Steve" };
    //    Console.WriteLine("Type of ano is {0}", ano.GetType());

    //    var arr = new[] { 1, 10, 20, 30 };
    //    Console.WriteLine("Type of arr is {0}", arr.GetType());

    //    var file = new FileInfo("MyFile");
    //    Console.WriteLine("Type of file is {0}", file.GetType());

    //    var i4 = 100;

    //}
}

