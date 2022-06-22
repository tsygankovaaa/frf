using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace калькулятор_дробей
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
        class Fraction
        {
            //поля класса
            private int Numerator; //числитель
            private int Denominator; //знаменатель

            //конструкторы
            public Fraction(int num, int denum)
            {
                Numerator = num;
                Denominator = denum;
            }
            public Fraction(int num) : this(num, 1)
            {
            }
            //методы
            //метод нахождения наибольшего общего делителя 
            private static int NOD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }
            public Fraction Normalization()
            {
                var n = Math.Abs(Numerator);
                var d = Math.Abs(Denominator);
                var nod = NOD(n, d);
                var sign = Math.Sign(Numerator * Denominator);
                return new Fraction(sign * n / nod, d / nod);
            }
            //метод сложения дробей
            public Fraction Summ(Fraction a, Fraction b)
            {
                return new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator).Normalization();
            }

            //метод вычитания дробей

            //метод умножения дробей

            //метод деления дробей

            //метод вывода ответа (строковое представление)
            public override string ToString()
            {
                return Numerator.ToString() + "/" + Denominator.ToString();
                Console.ReadKey();
            }
            
        }
    }

}

