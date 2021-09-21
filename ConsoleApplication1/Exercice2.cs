using System;
namespace ConsoleApplication1
{
    public class Exercice2
    {
        private int AskUserForParameter() {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        
        public int Fib(int n1) {
            if (n1 <= 2)
                return 1;
            else
                return Fib( n1 - 1 ) + Fib( n1 - 2 );
        }
        
        public int Factorial(int number) {
            if (number == 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }
        
        public void Exo2Part1() {
            int n, i, m;
            Boolean check;
            do {
                n = AskUserForParameter();
            } while (n > 1000);
            Console.WriteLine($"Prime number between 1 and {n}:");
            
            for (int j = 2; j <= n; j++) {
                m = j / 2;
                check = false;
                for (i = 2; i <= m; i++) {
                    if (j % i == 0) {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                    Console.Write($"{j} ");
            }
        }

        public void Exo2Part2() {
            int n;
            do {
                n = AskUserForParameter();
            } while (n>1000);
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"F({i})={Fib(i)}");
            }
        }
        
        public void Exo2Part3() {
            int n;
            do {
                n = AskUserForParameter();
            } while (n>25);
            Console.WriteLine($"{n}!={Factorial(n)}");
        }
    }
}