﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class ArrayTools
    {
        private static Random rand = new Random();
        /// <summary>
        /// Вывод элементов массива на экран
        /// </summary>
        /// <typeparam name="T">Тип массива</typeparam>
        /// <param name="arr">Массив для вывода</param>
        public static void PrintArray<T>(T[,] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Вывод элементов массива ссылок на экран
        /// </summary>
        /// <typeparam name="T">Тип массива</typeparam>
        /// <param name="arr">Массив для вывода</param>
        public static void PrintArray<T>(T[][] arr)
        {
            Console.WriteLine();
            foreach (T[] arr1 in arr)
            {
                foreach (T item in arr1)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Инициализация массива ссылок элементами пока не будет 0
        /// </summary>
        /// <param name="arr">Массив для инициализации</param>
        public void InitArr(double[][] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i] = new double[1];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(0, 6);
                    if (arr[i][j] != 0.0) Array.Resize(ref arr[i], arr[i].Length + 1);
                }
            }
        }
    }
}
