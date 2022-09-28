Console.Clear();

int GetNumber (string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число или число меньше 1, введите любое положительное число: ";

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            if(result > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

int firstNumber = GetNumber("Введите первое число: ");
int secondNumber = GetNumber("Введите второе число: ");
int lengthArray = 1;
int arrayStart = 0;

// Выполняем проверку какое число меньше, с того и начнется результирующий цикл
if (firstNumber > secondNumber) {
    lengthArray = firstNumber - secondNumber + 1;
    arrayStart = secondNumber;
}
else {
    lengthArray = secondNumber - firstNumber + 1;
    arrayStart = firstNumber;
}

int[] numberArray = new int[lengthArray];

Console.WriteLine("Созданный массив:");

for (int i = 0; i < lengthArray; i++) 
{
    numberArray[i] = arrayStart;
    Console.Write(numberArray[i] + ", ");
    arrayStart++;
}

Console.WriteLine();