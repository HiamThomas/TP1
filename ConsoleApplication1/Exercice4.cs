using System;

namespace ConsoleApplication1
{
    public class Exercice4
    {
        private int AskUserForParameter() {
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        
        public void Exo4() {
            int n, m;
            do {
                Console.Write("n:");
                n = AskUserForParameter();
                Console.Write("m:");
                m = AskUserForParameter();
            } while (n <1 || n> 1000 || m <1 || m> 1000);
            
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (i == 0 || i == n-1) {
                        if (j == 0 || j == m - 1)
                            Console.Write('0');
                        else
                            Console.Write('-');
                    }
                    else if (j == 0 || j == m-1)
                        Console.Write('|');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine(' ');
            }
        }
    }
}