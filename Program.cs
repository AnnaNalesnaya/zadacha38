// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
int Prompt(string message)
{
    Console.ForegroundColor=ConsoleColor.White;
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}
double[] ArrayFill(int size)
{
    int i = 0;
    double[] array = new double[size];    
    while(i < size)
    {
        if (new Random().Next(0, 2) == 0)
        {
            array[i] = Math.Round(new Random().NextDouble() * new Random().Next(0, 100), 1);
        }
        else
        {            
            array[i] = new Random().Next(0, 100);
        }
        i++;
    }
    return array;
}
void PrintArrey(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write("{0, 4}", array[i]);
        if (i < array.Length - 1)
        {
            System.Console.Write(" , ");
        }        
    }
    System.Console.Write("]");
}
double FindMin(double[] array)
{
    double minNum = array[0];
    for (int i = 0; i < array.Length; i++)  
    {
        if (array[i] < minNum)
        {
            minNum = array[i];
        }
    }
    return minNum;   
}
double FindMax(double[] array)
{
    double maxNum = array[0];
    for (int i = 0; i < array.Length; i++)  
    {
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
    }
    return maxNum;   
}
double DifferenceMinMax(double[] array)
{
 return FindMax(array) - FindMin(array);
}
int sizeArray = Prompt("введите размер массива: ");
for (int i = 0; i < 4; i++)
{
    double[] newArray = ArrayFill(sizeArray);
    PrintArrey(newArray);  
    System.Console.Write("-> ");
    System.Console.WriteLine($"{DifferenceMinMax(newArray):f2}"); 
}
 
