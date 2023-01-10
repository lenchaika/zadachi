// собрать строку с числами от а до b , a <= b
// string NumberFor(int a, int b)
// {
//     string result = string.Empty;
//     for (int i =a; i <=b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumberRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumberRec(a +1, b);
//     else return string.Empty;
// }

// Console.WriteLine(NumberFor(1, 10));
// Console.WriteLine(NumberRec(1, 10));

// собрать строку с числами от а до b , a >= b

// string NumberFor(int a, int b)
// {
//     string result = string.Empty;
//     for (int i = a; i >=b; i--)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumberRec(int a, int b)
// {
//     if (a <= b) return NumberRec + $"{a} ";
//     else return string.Empty;
// }

// Console.WriteLine(NumberFor(1, 10));
// Console.WriteLine(NumberRec(1, 10));


// сумма чисел от 1 до n

// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }
// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n -1);
// }
// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));

// факториал числа

// int FactorialFor(int n)
// {
//     int result = 1;
//     for(int i = 1; i<=n; i++) result *=i;
//     return result;
// }
// int FactorialRec(int n)
// {
//     if (n == 1) return1;
//     else return n * FactorialRec(n - 1);
// }
// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRec(10));

//вычислить а в степень n

// int PowerFor(int a. int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result =*;
//     result result;
//     }

//     int PowerRec(int a, int n)
//     {
//         // return n == 0 ? 1: PowerRec(a, n -1)* a;// записать одну строку. вместо ниже двух      if (n == 0) return 1;
//         else return PowerRec(a, n -1) * a;
//     }

//     int PowerRecMath(int a, int n)
//     { 
//         if (n ==0) return 1;
//         else if (n % 2 ==0) return PowerRecMath(a * a, n/2);
//         else return PowerRecMath(a, n -1) * a;
//     }
//     Console.WriteLine(PowerFor(2, 10));
//     Console.WriteLine(PowerRec(2, 10));
//     Console.WriteLine(PowerRecMath(2, 10));

//___________________________________

// int n = 1;
// void FindWords(string alphabet, char[]word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); 
//         return;
//     }

//         for(int i = 0; i < alphabet.Length; i++)
    
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }

// FindWords("аисв", new char[2]);

//______________________________________________________________
//мы хотим посмотреть все папки, лежащие внутри этой папки, и все файлы, находящиеся внутри папки.

// void CatalogInfo(string path, string indent = "")
// {
//      DirectoryInfo catalog = new DirectoryInfo(path);
//     DirectoryInfo[] catalogs = catalog.GitDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalog[i].Name}");
//         CatalogInfo(catalog[i].FullName, indent + "");
//     }
//     FileInfo[] files = catalog.GetFiles();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//       Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }
//  string path = @"C:\Users\akade\OneDrive\Рабочий стол\тестировщик\zadachi";
//  CatalogInfo(path);
//__________________________________________________

//блины и перемещение
// void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }
// Towers();
//____________________________________________________


//((4-2)*(1+3))/10

//tring[] tree = {emp,"/","*","10","-","+", emp,emp, "4", "2","1","3"};

string emp = String.Empty;
string[] tree = {emp,"/","*","10","-","+", emp,emp, "4", "2","1","3"};
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos  +1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[left]))InOrderTraversal(right);
    }
}
InOrderTraversal();