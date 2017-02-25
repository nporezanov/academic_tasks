using System;
using System.IO;

// Порезанов Николай. 
// Вспомогательный лист для тестирование кусков кода. 

namespace TestList
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            Console.WriteLine("Vvedi x: "); // ввод Х
            string str = Console.ReadLine();   // обьявлена переменная строковая str - ее значение считываеться с ввода. и записалась строка
            x = Convert.ToDouble(str);      // конвертация циферка Х = строковой str, преобразование строки в циферку Х 
            Console.WriteLine("Vvedi y: "); // ввод Y
            y = Convert.ToDouble(Console.ReadLine());
            double z = x + y;
            Console.WriteLine("{0}+{1}={2}", x, y, z); // Вывод Х+У=ЗетЪ
            Console.ReadKey();
        }
    }
}
