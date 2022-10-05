// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
// }
// Console.WriteLine($"Числовой ряд: {String.Join(", ", array)};");


// int count = 0;
// for (int p = 0; p < array.Length; p++)
// {
//     if (array[p] % 2 == 0) count++;
// }
// Console.WriteLine($"В ряду {count} чётных чисел.");




// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10, 10);
// }
// Console.WriteLine($"Числовой ряд: {String.Join(", ", array)};");


// Console.Write("Сумма чисел на нечётных позициях: ");
// int sum = 0;
// for (int p = 0; p < array.Length; p++)
// {
//     if (p % 2 != 0)
//     {
//         sum += array[p];
//         Console.Write($"{array[p]} (на {p}-й)");
//         if (p < array.Length -1) Console.Write(" + ");
//     }
// }
// Console.Write(" = " + sum);



// // Задача 38: Задайте массив вещественных чисел. 
// // Найдите разницу между максимальным и минимальным элементами массива.

// double[] array = new double[10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 100);
// }

// Console.WriteLine($"Числовой ряд: {String.Join(", ", array)};");

// double max = 0;
// double min = array[array.Length - 1];
// for (int j = 0; j < array.Length; j++)
// {
//     if (array[j] > max) max = array[j];
//     else if (array[j] < min) min = array[j];
// }

// Console.WriteLine($"Максимальное число: {max}");
// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"{max} - {min} = {max - min}");










// ____________________________________________________________________________________

// ЗАДАЧИ С СЕМИНАРА 5

// Массив из 12 элементов, заполненный случайными числами от -9 до 9.
// Найти сумму отрицательных и положительных элементов массива.

// int [] array = GetArray(12, -9, 9);
// Console.WriteLine(String.Join(« », array)); //вывести в терминал через пробел

// int posotiveSum = 0;
// int negativeSum = 0;

// for(int i = 0; i < array.Length; i++)
// {
// if (array[i] < 0
// {
// negativeSum = negativeSum + array[i]; // negativeSum += array[i]
// }
// else
// {
// positiveSum = positiveSum + array[i]; // positiveSum += array[i]
// }
// }
// Console.WriteLine($”Сумма положительных: { positiveSum }, сумма отрицательных: { negativeSum }”);

// // Массив из 12 элементов, заполненный случайными числами от -9 до 9.

// int GetArray(int size, int minValue, int maxValue)
// {
// int [] res = new int[size];
// for (int i = 0; i < size; i++)
// 	{
// 	res[i] = new Random().Next(minValue, maxValue + 1);
// 	}
// 	return res;
// }

// ЗАМЕНА ПОЛОЖИТЕЛЬНЫХ ЭЛЕМЕНТОВ МАССИВА НА ОТР. 
// случайное заполнение


// int[] numbers = new int [10];
// FillArray (numbers);
// Console.WriteLine($"Первоначальные числа: {String.Join(", ", numbers)};");
// Replace (numbers);
// Console.WriteLine("Заменённые числа:    " + String.Join(", ", numbers) + ";");

// void FillArray (int[] array)			
// {
// 	for (int i = 0; i < array.Length; i++)	
// 	{
// 		array[i] = new Random().Next(-99, 100);
// 	}
// }

// void Replace (int[] arr)
// {
// for (int j = 0; j < arr.Length; j++)
// {
//     if (arr[j] > 0) arr[j] = - arr[j];
// }
// }




// ЕСТЬ ЛИ В МАССИВЕ ЗАДАННОЕ ЧИСЛО

// int[] numbers = new int [10];
// FillArray (numbers);
// Console.WriteLine($"Первоначальные числа: {String.Join(", ", numbers)};");
// Console.Write("Найти число: ");
// int a = int.Parse(Console.ReadLine()!);
// FindNumber(numbers, a);


// void FindNumber(int[] ar, int arg)
// {
//     for(int p = 0; p < ar.Length; p++)
//     {
//         if (ar[p] == arg) 
//         {
//             Console.WriteLine("Есть такое число.");
//             break;
//         }
//     }
//     【??】 Console.WriteLine("Нет такого числа.");
// }


// void FillArray (int[] array)			
// {
// 	for (int i = 0; i < array.Length; i++)	
// 	{
// 		array[i] = new Random().Next(0, 3);
// 	}
// }


// ЗАМЕНА СИМВОЛА В СТРОКЕ БЕЗ ПЕРЕЗАПИСИ(??)

// string text = "вот эта фраза";
// Replace(text, 'а', 'А');
// Console.WriteLine(text);

// void Replace(string str, char oldS, char newS)
// {
// for (int i = 0; i < str.Length; i++)
//     {
//         if (str[i] == oldS) str[i] = newS;  //?? 
//     }
// }
