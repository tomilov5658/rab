using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите действие: \n1) +\n2) -\n3) *\n4) /");
            int vari = int.Parse(Console.ReadLine());
            switch (vari)
            {
                case 1:
                    pluss(A, B);
                    break;
                case 2:
                    minus(A, B);
                    break;
                case 3:
                    multy(A, B);
                    break;
                case 4:
                    devide(A, B);
                    break;
            }
            void pluss(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            void minus(int a, int b)
            {
                Console.WriteLine(a - b);
            }       
            
            void devide(int a, int b)
            {
                double _1 = (double)a;
                double _2 = (double)b;
                Console.WriteLine(_1 / _2);
            }
            void multy(int a, int b)
            {
                Console.WriteLine(a * b);

            }
        }
    }
        
}
