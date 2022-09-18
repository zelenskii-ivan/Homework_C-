// Напишите программу, которая на вход принимает число (N > 0), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8




Console.WriteLine("Введите число N");
 int n = Convert.ToInt32(Console.ReadLine());

 if (n < 2)
 {
     Console.WriteLine("пустое множество");
 }
 else
 {
     string result = "2";
     int index = 4;

     while (index < n)
     {
         result += (", " + index);
         index = index + 2;
     }

     Console.WriteLine("Чётные числа от 1 до N: " + result);
 }
