/*
 * ФИО: Чичканов Александр Германович
 * Дисциплина: программирование
 * Вариант: *
 * Группа: 161.1
 * Дата **.**.****
 */

using System;
using MyLibrary;
using System.Linq;

namespace KR2module
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number;
 
            int[] arr;

            Console.Title = "Chichkanov";

            do
            {
                Console.Clear();

                //Примеры ввода файла с проверкой на валидность
                IOTools.ReadInteger(out number, num => num > 0);

                arr = new int[number];         

                ShowProgramNotification();
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// Уведомление пользователя о работе программы
        /// </summary>
        private static void ShowProgramNotification()
        {
            Console.WriteLine("Нажмите любую клавишу для повторного решения.\nНажмите ESC для выхода.");
        }
    }
}
