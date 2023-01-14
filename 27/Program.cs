//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
int number = GetNumberFromUser("Ввдеите целое число А: ", "Ошибка ввода!");
int sumDigNumber = GetSumDigNumber(number);
Console.WriteLine($"{number} -> {sumDigNumber}");

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

int GetSumDigNumber(int num) 
{
    int result = 0;
    while(num > 0) 
    {
        int a = num % 10;
        result += a;
        num = num / 10;        
    }
    return result;
}
