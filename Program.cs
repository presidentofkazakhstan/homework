using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("ЗАДАЧА №1");
            Console.WriteLine("1  2  3");
            Console.WriteLine("--------------------------------------------------");

            //2
            Console.WriteLine("ЗАДАЧА №2");
            Console.WriteLine("5");
            Console.WriteLine("10");
            Console.WriteLine("21");
            Console.WriteLine("--------------------------------------------------");

            //3
            Console.WriteLine("ЗАДАЧА №3");
            Console.Write("Введите расстояние в сантиметрах: ");
            int cm = int.Parse(Console.ReadLine());
            int hundred = 100;
            int metr = cm / hundred;
            Console.WriteLine("Расстояние в метрах: " + metr);

            Console.WriteLine("--------------------------------------------------");


            //4
            Console.WriteLine("ЗАДАЧА №4");
            int seven = 7;
            int day = 234;
            int week = day / seven;
            Console.WriteLine("Прошло: 234 дня ");
            Console.WriteLine("Полных недель прошло: " + week);

            Console.WriteLine("--------------------------------------------------");


            //5
            Console.WriteLine("ЗАДАЧА №5");
            Console.Write("Введите двузначное число: ");
            int number = int.Parse(Console.ReadLine());
            int ten = 10;
            int summa = 0;

            int a1 = number / ten;
            int a2 = number % ten;
            int proiz = a2 * a1;
            int sum = a1 + a2;

            Console.WriteLine("Десятков: " + a1);
            Console.WriteLine("Единицы: " + a2);
            Console.WriteLine("Произведение двух цифр: " + proiz);
            Console.WriteLine("Сумма двух цифр: " + summa);

            Console.WriteLine("--------------------------------------------------");


            //6
            Console.WriteLine("ЗАДАЧА №6");
            bool A = true;
            bool B = false;
            bool C = false;
            Console.Write("A || B = ");
            Console.WriteLine(A || B);

            Console.Write("A && B = ");
            Console.WriteLine(A && B);

            Console.Write("B || C = ");
            Console.WriteLine(B || C);

            Console.WriteLine("--------------------------------------------------");


            //7
            Console.WriteLine("ЗАДАЧА №7");

            Console.Write("Введите радиус круга : ");
            int R = int.Parse(Console.ReadLine());
            var SKrug = Math.PI * R * R;
            Console.WriteLine("Площадь круга: " + SKrug);
            Console.WriteLine(" ");


            Console.Write("Введите сторону квадрата : ");
            int a = int.Parse(Console.ReadLine());
            var SKvadrat = a * a;
            Console.WriteLine("Площадь квадрата: " + SKvadrat);
            Console.WriteLine(" ");

            if (SKrug > SKvadrat)
            {
                Console.WriteLine(SKrug + " > " + SKvadrat);
            }
            else if (SKrug < SKvadrat)
            {
                Console.WriteLine(SKrug + " < " + SKvadrat);
            }
            else { Console.WriteLine(SKrug + " = " + SKvadrat); }

            Console.WriteLine("--------------------------------------------------");


            //8
            Console.WriteLine("ЗАДАЧА №8");

            Console.Write("Введите массу первого тела: ");
            var m1 = int.Parse(Console.ReadLine());
            Console.Write("Введите объём первого тела: ");
            var V1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Введите массу второго тела: ");
            var m2 = int.Parse(Console.ReadLine());
            Console.Write("Введите объём второго тела: ");
            var V2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            var p1 = m1 / V1;
            var p2 = m2 / V2;

            Console.WriteLine("Плотность первого тела: " + p1);
            Console.WriteLine("Плотность второго тела: " + p2);

            Console.WriteLine(" ");

            if (p1 > p2)
            {
                Console.WriteLine("Первого тело имеет большее плотность");
                Console.WriteLine(p1 + " > " + p2);
            }
            else if (p1 < p2)
            {
                Console.WriteLine("Второе тело имеет большее плотность");
                Console.WriteLine(p1 + " < " + p2);
            }
            else
            {
                Console.WriteLine("Плотности двух тел равны");
                Console.WriteLine(p1 + " = " + p2);
            }

            Console.WriteLine("--------------------------------------------------");

            //9
            Console.WriteLine("ЗАДАЧА №9");

            Console.Write("Введите напряжение первого участка электрической цепи: ");
            var U1 = int.Parse(Console.ReadLine());
            Console.Write("Введите сопротивление первого участка электрической цепи: ");
            var R1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Введите напряжение второго участка электрической цепи: ");
            var U2 = int.Parse(Console.ReadLine());
            Console.Write("Введите сопротивление второго участка электрической цепи: ");
            var R2 = int.Parse(Console.ReadLine());


            Console.WriteLine(" ");

            var I1 = U1 / R1;
            var I2 = U2 / R2;

            Console.WriteLine("Ток первой цепи: " + I1);
            Console.WriteLine("Ток второй цепи: " + I2);

            Console.WriteLine(" ");

            if (I1 > I2)
            {
                Console.WriteLine("По второму участку протекает меньший ток");
                Console.WriteLine(I1 + " > " + I2);
            }
            else if (I1 < I2)
            {
                Console.WriteLine("По первому участку протекает меньший ток");
                Console.WriteLine(I1 + " < " + I2);
            }
            else if (I1 == I2)
            {
                Console.WriteLine("По обоим участкам протекает одинаковый ток");
                Console.WriteLine(I1 + " = " + I2);
            }
            Console.WriteLine("--------------------------------------------------");


            //10
            Console.WriteLine("ЗАДАЧА №10");
            Console.WriteLine("                           A)");
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("                           B)");
            Console.Write("Введите число, до которого будут выводиться квадраты числ начиная с 10: ");
            var b = int.Parse(Console.ReadLine());
            for (int i = 10; b >= i; i++)
            {
                var kvChisel = i * i;
                Console.WriteLine(kvChisel);
            }

            Console.WriteLine("                            C)");
            Console.Write("Введите число, от которого будет выводится кубы числ до 50: ");
            var num_1 = int.Parse(Console.ReadLine());
            for (; a < 50; a++)
            {
                var trStepenChisel = a * a * a;
                Console.WriteLine(trStepenChisel);
            }
            Console.WriteLine("                            D)");
            Console.WriteLine("Введите число, от которого будет выводится целые числа: ");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число, до которого будет выводится целые числа: ");
            var num2 = int.Parse(Console.ReadLine());
            for (; num2 >= num1; num1++)
            {
                Console.Write(num1 + " ");
            }
            Console.Read();
        }
    }
}