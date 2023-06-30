Console.Write("Введите пятизначное число: ");
int input = Convert.ToInt32(Console.ReadLine());

if (IsPalindrome(input))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

static bool IsPalindrome(int number)
{
    string numberStr = Math.Abs(number).ToString();

    if (numberStr.Length != 5)
    {
        Console.WriteLine("Число должно быть пятизначным.");
        return false;
    }

    for (int i = 0; i < numberStr.Length / 2; i++)
    {
        if (numberStr[i] != numberStr[numberStr.Length - i - 1])
            return false;
    }

    return true;
}

// В этом коде генерирует пятизначные палиндромы.
// for (int i = 10000; i <= 99999; i++)
// {
//     if (IsPalindrome(i))
//     {
//         Console.WriteLine(i);
//     }
// }


// static bool IsPalindrome(int number)
// {
//     string numberStr = Math.Abs(number).ToString();

//     for (int i = 0; i < numberStr.Length / 2; i++)
//     {
//         if (numberStr[i] != numberStr[numberStr.Length - i - 1])
//             return false;
//     }

//     return true;
// }