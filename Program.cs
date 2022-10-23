/**Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
/*
int[] CreateNewArray(int size)
{
    int [] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(100,1000);
    }
    return myArray;
}

void ShowArray (int[]array)    //покажи массивif (array[i] % 2 == 0)
{
    Console.Write("Получившийся массив -> " );
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i]+ " ");
    }      
}  
int ElementCount (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateNewArray(a);
ShowArray (myArray);
int result = ElementCount(myArray);
Console.WriteLine($"В этом массиве содержится {result} четных числа");*/ 

/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1); 
    }
    return myArray;
}
void ShowArray (int[]array)    //покажи массив
{
    Console.Write("Получившийся массив -> " );
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i]+ " ");
    }      
}  
int ElementCount (int[] array)
{   
    int SumElement = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        SumElement += array[i];   
    }
     return SumElement;
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(a, min, max);
ShowArray (myArray);
int result = ElementCount(myArray);
Console.WriteLine ($"сумма элементов стоящих на нечетных позициях -> {result}");*/

/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1); 
    }
    return myArray;
}

void ShowArray (int[]array)    //покажи массив
{
    Console.Write("Получившийся массив -> " );
    for (int i = 0; i<array.Length; i++)
    {
    Console.Write(array[i]+ " ");
    }      
}  

int FindMinMax (int[] array)
{
    int result = 0;
    int min = 0;
    int max = 0;

    for (int i = 0; i < array.Length; i++)
    {
     if (array[min] > array[i])
     min = i;
     else if (array[max] < array[i])
     max = i;
    }
     result = array[max] - array[min];
     return result;
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(a, min, max);
ShowArray (myArray);
int result = FindMinMax (myArray);
Console.WriteLine($"разница между максимальным и минимальным элементом массива = {result} ");*/


  




