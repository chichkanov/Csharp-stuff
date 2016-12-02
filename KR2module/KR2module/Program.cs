/*
 * ФИО: Чичканов Александр Германович
 * Дисциплина: программирование
 * Вариант: *
 * Группа: 161.1
 * Дата **.**.****
 */

using System;

namespace KR2module
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Chichkanov";

            do
            {
                Console.Clear();

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
