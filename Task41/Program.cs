// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример: 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите чиселa через запятую: ");
string? text = Console.ReadLine().Replace(" ", "");

int HowManyPositiveNumbers(string txt)
{
    int index = txt.IndexOf(',');
    if (index != -1)
    {
        int num = Convert.ToInt32(txt.Substring(0, index));
        txt = txt.Substring(index + 1);
        return HowManyPositiveNumbers(txt) + (num > 0 ? 1 : 0);
    }
    else if (txt.Length > 0)
    {
        return Convert.ToInt32(txt) > 0 ? 1 : 0;
    }
    return 0;
}

Console.WriteLine(HowManyPositiveNumbers(text));