Console.Clear();

// int NaturalNumbers(int num)
// {
//     if (num > 0) Console.Write(num + " ");
//     return num - NaturalNumbers(num - 1);
// }
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 0)
// {
//     NaturalNumbers(number);
// }

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// void TotalGap(int n, int m)
// {
//     int max = n;
//     int min = m;
//     if (n < m) max = m; min = n;
//     int total = 0;
//     for (int i = 0; i < max; i++)
//     {
//         if (min <= max)
//         {
//             total = total + min;
//             min++;
//         }
//     }
//     Console.WriteLine(total);
// }
// if (n > 0 && m > 0)
// {
//     TotalGap(n, m);
// }

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int m = 3; int n = 2;
// int AccermanFunc(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (m > 0 && n == 0) return AccermanFunc(m - 1, 1);
//     else if (m > 0 && n > 0) return AccermanFunc(m - 1, AccermanFunc(m,n-1));
//     return 0;   
// }
// if (n > -1 && m > -1)
// {
//     int res = AccermanFunc(n,m);
//     Console.WriteLine(res);
// }