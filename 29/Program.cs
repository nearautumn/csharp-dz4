//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
int[] array = new int[8];
int n = 0;
for (int i = 0; i < 8; i++) 
{
    array[i] = GetNumberFromUser($"Ввдеите целое число (элемент массива № {n}): ", "Ошибка ввода!");
    n++;
}
Console.Clear();
printArray(array);

int GetNumberFromUser(string message, string errorMessage) 
{
    while(true) 
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

void printArray(int[] numbers) 
{
    for (int index = 0; index < 7; index++) 
    {
        Console.Write($"{numbers[index]}, ");
    }
    Console.Write($"{numbers[7]} -> [");
    for (int index = 0; index < 7; index++) 
    {
        Console.Write($"{numbers[index]}, ");
    }
    Console.Write($"{numbers[7]}]");
}