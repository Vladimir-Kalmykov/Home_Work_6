// // Задача № 1.Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Количество чисел после нуля: {count}");


// Задача № 2.Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

// int[] array = GetArray(6, 0, 100);
// Console.WriteLine($"[{String.Join(",", array)}]");

// BubbleSort(array);
// Console.WriteLine($"[{String.Join(",", array)}]");
// // метод
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// void BubbleSort(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         for (int j = 0; j < array.Length - 1; j++)
//             if (array[j] > array[j + 1])
//             {
//                 int t = array[j + 1];
//                 array[j + 1] = array[j];
//                 array[j] = t;
//             }
// }