// Задача 68. Вычисление функции Аккермана с помощью рекурсии. 

Console.Clear();

Console.WriteLine($"Избегайте ввода больших значений чисел. Функция Аккермана быстрорастущая.");
int a = InputOfDigits("Укажите первое число a: ");
int b = InputOfDigits("Укажите второе число b: ");

int FuncOfAkkerman = AFunc(a, b);

Console.Write($"Значение функции Аккермана = {FuncOfAkkerman} ");

int AFunc(int a, int b)
{
  if (a == 0) return b + 1;
  else if (b == 0) return AFunc(a - 1, 1);
  else return AFunc(a - 1, AFunc(a, b - 1));
}

int InputOfDigits(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
