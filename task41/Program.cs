// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] Numbers = new int[size];
InputNumbers(size);
Console.WriteLine($"Количество чисел больше нуля: {CheckPositiveEl(Numbers)} ");

void InputNumbers(int size)
  {
   for (int i = 0; i < size; i++)
      {
        Console.Write($"Введите {i+1} число: ");
        Numbers[i] = Convert.ToInt32(Console.ReadLine());
      }
  }

int CheckPositiveEl(int[] Numbers)
 {
    int count = 0;
    for (int i = 0; i < size; i++)
      {
       if(Numbers[i] > 0 ) count += 1; 
      }
   return count;
 }



