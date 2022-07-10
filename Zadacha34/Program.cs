/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Random random = new Random(); //рандомное число
int size = random.Next(1,10);
int[] array = new int[size];
int firstNumber = 100;
int lastNumber = 999;

fillArray(array, firstNumber, lastNumber);
printArray(array);
countNumber(array);

//Заполнение массива случайными числами от -10 до 10
static void fillArray(int[] A, int First, int Last)
{
    Random random = new Random();
    for (int i = 0; i < A.Length; i ++)
    {
        A[i] = random.Next(First, Last);
    }
}

//Вывод массива
static void printArray(int[] A)
{
    for (int i = 0; i < A.Length; i ++)
    {
        Console.Write(A[i] + "  ");
    }
    Console.WriteLine();
}

//Проверка на четность, кол-во четных чисел
static void countNumber(int[] A)
{
    int count = 0;
    for (int i = 0; i < A.Length; i ++)
    {
        if (A[i] % 2 == 0)
        {
            count = count + 1;
        } 
    }
    Console.WriteLine("Количество четных чисел в массиве: " + count);
}