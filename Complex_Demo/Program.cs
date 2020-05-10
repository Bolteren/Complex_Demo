using System;

namespace Complex_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex z1 = new Complex(2, 3);
            Complex z2 = new Complex(-1, 1);
            Complex z3 = new Complex(4, 6);
            int n = 2;
            Console.WriteLine("Сумма комплексных чисел\t\t\t\t\t{0} + {1} = {2}", z1, z2, z1 + z2);
            Console.WriteLine("Разность комплексных чисел\t\t\t\t{0} - {1} = {2}", z1, z2, z1 - z2);
            Console.WriteLine("Сумма действительного и комплексного чисела\t\t{0} + {1} = {2}", n, z1, n + z1);
            Console.WriteLine("Сумма комплексного и действительного чисела\t\t{0} + {1} = {2}", z1, n, z1 + n);
            Console.WriteLine("Разность комплексного и действительного чисела\t\t{0} - {1} = {2}", z2, n, z2 - n);
            Console.WriteLine("Разность действительного и комплексных чисел\t\t{0} - {1} = {2}", n, z2, n - z2);
            Console.WriteLine("Умножение комплексных чисел\t\t\t\t{0} * {1} = {2}", z1, z2, z1 * z2);
            Console.WriteLine("Умножение действительного и комплексного чисела\t\t{0} * {1} = {2}", n, z1, n * z1);
            Console.WriteLine("Умножение комплексного и действительного чисела\t\t{0} * {1} = {2}", z1, n, z1 * n);
            Console.WriteLine("Деление комплексных чисел\t\t\t\t{0} / {1} = {2}", z3, z1, z3 / z1);
            Console.WriteLine("Деление комплексного и натурального чисела\t\t{0} / {1} = {2}", z3, n, z3 / n);
            Console.WriteLine("Деление действительного и комплексного чисела\t\t{0} / {1} = {2}", n, z2, n / z2);
            Console.ReadKey();
        }
    }
}
