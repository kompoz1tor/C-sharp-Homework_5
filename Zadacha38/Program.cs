/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

Дополнительные задачи
*/

Random random = new Random(); //рандомное число
int size = random.Next(3,7);
double[] array = new double[size];
int firstNumber = 5;
int lastNumber = 100;

fillArray(array, firstNumber, lastNumber);
printArray(array);
countNumber(array);

//Заполнение массива случайными числами от -10 до 10
static void fillArray(double[] A, int First, int Last)
{
    Random random = new Random();
    for (int i = 0; i < A.Length; i ++)
    {
        A[i] = random.Next(First, Last);
    }
}

//Вывод массива
static void printArray(double[] A)
{
    for (int i = 0; i < A.Length; i ++)
    {
        Console.Write(A[i] + "  ");
    }
    Console.WriteLine();
}

//Ищем максимальное значение, минимальное значение. Высчитываем разницу между ними.
static void countNumber(double[] A)
{
    double max = A[0];
    double min = A[0];
    for (int i = 0; i < A.Length; i ++)
    {
        if (A[i] < min)
        {
            min = A[i];
        }
        if (A[i] > max)
        {
            max = A[i];
        }
    }
    double result = max - min;
    Console.WriteLine("Максимальное число в массиве: " + max);
    Console.WriteLine("Минимальное число в массиве: " + min);
    Console.WriteLine("Разница между максимальным и минимальным элементов массива равна: " + result);
}