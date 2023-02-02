// 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


// int[] array = GetArrey(8,100,999);
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine($"Количество чётных чисел в массиве -> {CauntElement(array)}");


// 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// int[] array = GetArrey(8,100,999);
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine($"Сумма элементов стоящих на нечётных индексах -> {GetSum(array)}");


// 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

int[] StartArray = GetArrey(5,0,10);
Console.WriteLine($"[{String.Join(",", StartArray)}]");
Console.WriteLine($"[{String.Join(",", NewArray(StartArray))}]");




//-------------методы-----------------

int[] GetArrey(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int CauntElement(int[] array)
{
    int count = 0;
    foreach(int el in array)
  {
    if(el % 2 == 0)
    {
        count++;
    }
  }
return count;
}


int GetSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}


int[] NewArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size ++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];
    return result;
}