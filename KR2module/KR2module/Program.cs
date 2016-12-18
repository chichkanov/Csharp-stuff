/*
 * ФИО: Чичканов Александр Германович
 * Дисциплина: программирование
 * Вариант: *
 * Группа: 161.1
 * Дата **.**.****
 */

using System;
using MyLibrary;

namespace KR2module
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int number2;
            Console.Title = "Chichkanov";

            do
            {
                Console.Clear();

                //Примеры ввода файла с проверкой на валидность и без
                MyTools.ReadNumber(out number, "Enter a number: ", "Error", num => num > 0);
                MyTools.ReadNumber(out number2, "Enter a second number: ", "Error");

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
