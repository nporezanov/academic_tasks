using System;
using System.IO;

// Порезанов Николай.  Домашнее задание с первого занятия от 24.02.2017
/*
 * Написать программу“Анкета”. Последовательно задаютсявопросы(имя, фамилия, возраст,
  рост, вес). В результате вся информация выводится в одну строчку.
      а)используя склеивание;
б) используя форматированный вывод.
*/

namespace HomeWork_24_02_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Вас приветствует программа -=Анкета=-. Нажмите Enter для продолжения.");
            Console.ReadKey();
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Укажите ваш возраст (введите только числовое значение полных лет!)");
            string age = Console.ReadLine();
            Console.WriteLine("Укажите ваш рост (число в сантиметрах)");
            string heigth = Console.ReadLine();
            Console.WriteLine("Укажите ваш вес (число в килограммах)");
            string weigth = Console.ReadLine();

            Console.WriteLine("Результат А):"+name+" "+surname+", возраст "+age+", рост - "+heigth+" см, вес "+weigth+" кг." ); // Используеться склеивание при выводе результата
            Console.WriteLine("Результат Б): {0} {1}, возраст {2}, рост - {3} см, вес {4} кг.", name, surname, age, heigth, weigth); // Используеться форматированный вывод.
            Console.ReadLine();


        }
    }
}
