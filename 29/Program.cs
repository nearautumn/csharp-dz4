//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
createArray();

void createArray() 
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++) 
    {
        array[i] = int.Parse(Console.ReadLine() ?? "");
    }
}