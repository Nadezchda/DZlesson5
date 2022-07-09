
// ПРАКТИЧЕСКОЕ ЗАДАНИЕ 5

// Задайте массив заполненный случайными
//  положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] Array8 (int size, int min, int max)
// {
//    int[] array = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//    array[i] = new Random().Next(99,1000);
//    }
//    return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//     Console.Write(array[i] + ", ");
//     }
// }
// int [] myArray = Array8(10, 99, 100);
// ShowArray(myArray);

//  void Positive(int[] array){
//  int count = 0;
//  for (int i = 0; i<array.Length; i++ ){
//  if (array[i] % 2 == 0)
//     {
//  count++;
//     }
//     }
// Console.WriteLine("-> " + count);
//  }      
//  Positive(myArray);

// РЕШЕНА!!!

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//    int[] Array9 (int size, int min, int max)
// {
//     int[] array = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//    array[i] = new Random().Next(0 , 1000);
//    }
//     return array;
//  }
//  void ShowArray(int[] array)
//  {
//      for (int i = 0; i < array.Length; i++)
//      {
//     Console.Write(array[i] + ", ");
//      }
//  }
//  int [] myArray = Array9( size: 6, min: 0 ,max: 1000);
//  ShowArray(myArray);

//   void UNPositive(int[] array){
//   int sum = 0;
//   for (int i = 1; i<array.Length; i= i + 2 ){
//     {
//     sum = sum + array[i];
//      }
//      }
//  Console.WriteLine("-> " + sum);
//   }      
//   UNPositive(myArray);
 
// решена !!!

// Задайте массив вещественных чисел. Найдите разницу
//  между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

    double[] array = new double[6];
    for (int i = 0; i < array.Length; i++)
  {
    array [i] = new Random().Next(-2, 10);
    Console.Write(array[i] + ",");
  }
    double min = array[0]; double max = array[0] ;       
    for (int i = 1; i < array.Length; i++)
  {
    if (max < array[i])
  {
      max = array[i];
  }
     if (min > array[i])
  {
      min = array[i];
  }
  }
  double decision = max - min;
Console.WriteLine($"\nразница max ({max}) и min ({min}) = {decision}");

            
    
// Дополнительно:
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21