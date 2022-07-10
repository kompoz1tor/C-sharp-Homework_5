/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
Random random = new Random(); //рандомное число
int size = random.Next(3,5);
int[] array = new int[size];
int firstNumber = -100;
int lastNumber = 100;

fillArray(array, firstNumber, lastNumber);
printArray(array);
sumArray(array);

//Заполнение массива случайными числами от -100 до 100
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

//Сумма элементов на четных позициях
static int sumArray(int[] A)
{
    int sum = 0;
    for (int i = 0; i < A.Length; i ++)
    {
        if (i % 2 == 0)
        {
            sum = sum + A[i];
        }
    }
    return sum;
    
}
Console.Write("Сумма нечетных элементов массива равна: " + sumArray(array));