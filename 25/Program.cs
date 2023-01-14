// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
int numA = GetNumberFromUser("Ввдеите целое число А: ", "Ошибка ввода!");
int numB = GetNumberFromUser("Ввдеите целое число B: ", "Ошибка ввода!");
int result = GetPow(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {result}");

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

int GetPow(int a, int b) 
{
    int res = a;
    for(int i = 2; i <= b; i++) 
    {
        res = res * a;
    }
    return res;
}