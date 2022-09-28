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

int Akkerman (int m, int n)
{
  if (m == 0) return n + 1;
  else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int firstNumber = GetNumber("Введите первое число: ");
int secondNumber = GetNumber("Введите второе число: ");
int result = Akkerman(firstNumber, secondNumber);

Console.WriteLine("Результат по функции Аккермана: " + result);