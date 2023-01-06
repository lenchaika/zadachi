//void Method1()
//{
//    Console.WriteLine("Автор...");
//}

//Method1();

//void Method2(string msg) //метод ничего не возвращает но принимает на себя аргументы
//{
//    Console.WriteLine(msg);
//}

//Method2("Текст сообщения");

void Method21(string msg, int count) //метод ничего не возвращает но принимает на себя аргументы
{
    int i = 0;
    while(i < count)
    {
        i++;
         Console.WriteLine(msg);
    }
}

Method21(msg:"Текст", 4); // метод увидеть 4 раза// msg-коонкретный аргумент


int Method3()//методы что-то возвращают но ничего не принимают
{
    return DateTime.Now.Year;
}

int Year = Method3();
Console.WriteLine(Year);




//strimg Method4(int count, string c) //метод которые что-то принимают и что-то возвращают
//{
//    int i = 0; //счетчик
//    string result = String.Empty;
//
//   while(i < count)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}
//string res = Method4(10, "z");
//Console.WriteLine(res);

//еще один способ с for
// string Method4(int count, string c) 
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
   
//     {
//         result = result + text;
//    }
//   return result;
// }
// string res = Method4(10, "z");
//Console.WriteLine(res);


 for(int i = 2; i <= 10; i++)
 {
     for(int j = 2; j <= 10; j++)
     {
        Console.WriteLine($"{i} x {j} = {i * j}");
     }
     Console.WriteLine();// переход на новую строку.пробел
 }