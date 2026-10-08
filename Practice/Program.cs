// int a =Convert.ToInt32(Console.ReadLine());
// for (int i=1; i<=a; i++)
// {
//     Console.Write(i+" ");
// }


// int a =Convert.ToInt32(Console.ReadLine());
// for (int i=1; i<=a; i++)
// {
//     Console.Write(i);
// }


// int a =Convert.ToInt32(Console.ReadLine());
// for (int i=1; i<=a; i++)
// {
//     Console.Write(i);
// }
// System.Console.WriteLine();
// for (int i=a; i>=1; i--)
// {
//     Console.Write(i);
// }

// int a =Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();
// for (int i=a; i>=1; i--)
// {
//     Console.WriteLine(i+" Hello world");
// }

// int a =Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();
// for (int i=1; i<=a; i++)
// {
//     Console.WriteLine(i+" Hello world");
// }





// string? a= Console.ReadLine();
// if (a.Length > 5)
// {
//     System.Console.WriteLine("Long Name");
// }
// else if (a.Length <= 5)
// {
//     System.Console.WriteLine("Short Name");
// }

// string? a= Console.ReadLine();
// if(a[a.Length-1]=='z' || a[a.Length-1] == 'Z')
// {
//     System.Console.WriteLine("Ends with Z");
// }
// else if(a[0]=='a' || a[0] == 'A')
// {
//     System.Console.WriteLine("Starts with A");
// }
// else
// {
//     System.Console.WriteLine("Normal");
// }

// int a =Convert.ToInt32(Console.ReadLine());
// int n1=a/100;
// int n3=a%10;

// if (n1 == n3)
// {
//     System.Console.WriteLine("It's Palindrome");
// }
// else
// {
//     System.Console.WriteLine("It's not Palindrome");
// }


// int a =Convert.ToInt32(Console.ReadLine());
// int n1=a/100;
// int n2 =a/10%10;
// int n3=a%10;
// if(n1>n2 && n1 > n3)
// {
//     System.Console.WriteLine("first");
// }
// if (n2>n1 && n2>n3)
// {
//     System.Console.WriteLine("second");
// }
// else
// {
//     System.Console.WriteLine("third");
// }


// int a =Convert.ToInt32(Console.ReadLine());
// int n1=a/100;
// int n2 =a/10%10;
// int n3=a%10;
// if(n1<n2 && n2 < n3)
// {
//     System.Console.WriteLine("Yes");
// }

// else
// {
//     System.Console.WriteLine("No");
// }

// int a1 = Convert.ToInt32(Console.ReadLine());
// int a2 = Convert.ToInt32(Console.ReadLine());
// int a3 = Convert.ToInt32(Console.ReadLine());
// int a4 = Convert.ToInt32(Console.ReadLine());
// if(a1!=a2&& a1!=a3 && a1!=a4) System.Console.WriteLine(1);
// if(a2!=a1&& a2!=a3 && a2!=a4) System.Console.WriteLine(2);
// if(a3!=a2&& a3!=a1 && a3!=a4) System.Console.WriteLine(3);
// if(a4!=a2&& a4!=a3 && a4!=a1) System.Console.WriteLine(4);
int a =Convert.ToInt16(Console.ReadLine());

// float AddTwoNumbers(float a, float b)
// {
//     return a+b;
// }
// float SubTwoNumbers(float a, float b)
// {
//     return a-b;
// }
// float MulTwoNumbers(float a, float b)
// {
//     return a*b;
// }
// float DevTwoNumbers(float a, float b)
// {
//     return a/b;
// }
// float SquareNumbers(float a)
// {
//     return a*a;
// }

// double SqrtNumbers(double a)
// {
//     double s = Math.Sqrt(a);
//     return s;
// }


// int Factorial(int a)
// {
//     int cnt=1;
//     for (int i = 1; i <= a; i++)
//     {
//         cnt*=i;
//     }
//     return cnt;
// }
// System.Console.WriteLine(Factorial(a));

// int FirstSmaller(int a, int b)
// {
//     int min =a<b ? a : b;
//     return min+1;
// }

// double Abs (double a)
// {
//     double r =Math.Abs(a);
//     return r;
// }

// string OddEven(double a)
// {
//     if (a % 2 != 0)
//     {
//         return "Odd";
//     }
//     else return "Even";
// }

// string IsPrime(int a)
// {
//     int cnt=0;
//     for(int i=1; i<=a; i++)
//     {
//        if(a%i==0) cnt++; 
//     }
//     if (cnt == 2)
//     {
//         return "Prime";
//     }
//     else return "Not Prime";
// }

// string AddTwoString(string a, string b)
// {
//     string d= a+b;
//     return d;
// }


// int Length(string a)
// {
//     return a.Length;
// }

// string Equal(string a, string b)
// {
//     if (a.Length == b.Length)
//     {
//         return "Yes";
//     }
//     else return "No";
// }


// string CheckingUpTo10(int a)
// {
//    return a>=10? "true": "false";
// }


// string Palindrome(int a)
// {

// string s = a.ToString();

// for (int i = 0; i < s.Length / 2; i++)
// {
//     if (s[i] != s[s.Length - 1 - i])
//     {
//         return "No";
//     }
// }
// return "Yes";
// }

// System.Console.WriteLine(Palindrome(a));



// int Sum(int a, int b)
// {
//     return a+b;
// }


// int Increament1(int a)
// {
//     return a+1;
// }

// double AreaTriangle(double a, double b)
// {
//     return(a*b)/2;
// }


// double YearToDays(double a)
// {
//     return a*365;
// }

// string YearWork(int a)
// {
//     int s= 2026-a;

//     return s>=18 || s<=100 ? $"Welcome you are {s} years old" : $"You coudn work becouse you are {s} years old";
// }
// System.Console.WriteLine(YearWork(a));

// int SumOfNum(int a)
// {
//     int cnt = 0;
//    for (int i = 0; i <= a; i++)
//    {
//     cnt+=i;
//    }
//    return cnt;
// }
// System.Console.WriteLine(SumOfNum(a));


// int Min(int a)
// {
//     int min =int.MaxValue;
//     for (int i = 0; i <int.MaxValue ; i++)
//     {
//           int b = a % 10;
//           a = a / 10;


//     if (b < min)
//         min = b;
//     }
//     return min ;
// }
// int Max(int a)
// {
//     int max =int.MinValue;
//     for (int i = 0; i <int.MaxValue ; i++)
//     {
//           int b = a % 10;
//           a = a / 10;

//     if (b > max)
//         max = b;

   
// }
//     return max ;
// }
// System.Console.WriteLine(Min(a));
// System.Console.WriteLine(Max(a));


// int FindMin(int a, int b, int d, int v)
// {
//     int min =int.MaxValue;
//  if(a<min)  min=a;
//  if(b<min)  min=b;
//  if(d<min)  min=d;
//  if(v<min)  min=v;
//  return min;
// }


// double FindAvarage(double a, double b, double d, double v)
// {
//  double s=a+b+d+v;
//  return s/4;
// }

// double Area (char s ,double a)
// {
//     if (s=='s')
//     {
//         return a*4;
//     }
//     else if(s=='c') return 2*3.14*a;
//     else return 0;
// }

// int ToSec(int a)
// {
//     return a*60;
// }

// char Grade(int a)
// {
//     if(a>=90 && a <= 100)
//     {
//         return 'A';
//     }
//     else if(a>=80 && a<=89) return 'B';
//     else if(a>=70 && a<=79) return 'C';
//     else if(a>=60 && a<=69) return 'D';
//     else if(a<=59) return 'F';
//     else return '!';
// }

// string Palindrome(int a)
// {

// string s = a.ToString();

// for (int i = 0; i < s.Length / 2; i++)
// {
//     if (s[i] != s[s.Length - 1 - i])
//     {
//         return "No";
//     }
// }
// return "Yes";
// }

// System.Console.WriteLine(Palindrome(a));

// int Sum(int a)
// {
//     int cnt=0;
//     cnt+=a/1000;
//     cnt+=a/100%10;
//     cnt+=a/10%10;
//     cnt+=a%10;
//     return cnt;

// }
// System.Console.WriteLine(Sum(a));




// int Sum(int a)
// {
//     int cnt=0;
//     cnt+=a/100%10;
//     cnt+=a/10%10;
//     cnt+=a%10;
//     return cnt;

// }
// System.Console.WriteLine(Sum(a));

// double GetRemainder(double a, double b)
// {
//     return a%b;
// }
// double Quotient(double a, double b)
// {
//     return a%b-a/b;
// }

// double Getcube(double a)
// {
//     return a*a*a;
// }
// double GetPow(double a)
// {
//     return a*a;
// }
// System.Console.WriteLine(Getcube(a)/GetPow(a));
