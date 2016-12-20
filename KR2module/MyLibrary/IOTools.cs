using System;

namespace MyLibrary
{
    public class IOTools
    {
        /// <summary>
        /// Ввод элемента
        /// </summary>
        /// <param name="number">Число для ввода</param>
        /// <param name="checkNum">Проверки валидности</param>
        /// <param name="text">Текст ввода</param>
        /// <param name="errorText">Текст ошибки ввода</param>
        public static void ReadInteger(out int number, Func<int, bool> checkNum = null, string text = "Введите число: ", string errorText = "Ошибка")
        {
            Console.Write(text);
            while (!int.TryParse(Console.ReadLine(), out number) || (checkNum != null && !(checkNum(number))))
            {
                Console.WriteLine(errorText);
                Console.Write(text);
            }
            Console.Write("ОК\n\n");
        }
    }
}
