//Метод генерации массива со случайными элементами
int[] CreatArray(int arraySize, int arrayMinValue, int arrayMaxValue)
{
    int[] resArray = new int[arraySize];
    Random rnd = new Random();
    for (int i = 0; i < resArray.Length; i++)
    {
        resArray[i] = rnd.Next(arrayMinValue, arrayMaxValue + 1);
    }
    return resArray;
}


//Метод генерации массива со случайными вещественными элементами
double[] CreateArrayRndDouble(int arraySize, int arrayMinValue, int arrayMaxValue)
{
    double[] mainArray = new double[arraySize];//создание массива вещественных значений
    Random rnd = new Random();
    for (int i = 0; i < mainArray.Length; i++)
    {
        mainArray[i] = rnd.NextDouble() * (arrayMaxValue - arrayMinValue) + arrayMinValue;//получение рандом вещественного числа(по дефолту без множителя дает диапазон чисел от 0.0 до 1.0)
        mainArray[i] = Math.Round(mainArray[i], 1);//округление до 1го знака после запятой
    }
    return mainArray;
}


//Метод вывода массива в консоль
void PrintArrayDouble(double[] mainArray)
{
    Console.Write("[ ");
    for (int i = 0; i < mainArray.Length; i++)
    {
        if (i < mainArray.Length - 1) Console.Write(mainArray[i] + " | ");
        else Console.Write(mainArray[i]);
    }
    Console.WriteLine(" ]");
}