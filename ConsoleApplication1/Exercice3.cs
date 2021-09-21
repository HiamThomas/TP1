using System;

namespace ConsoleApplication1
{
    public class Exercice3
    {
        private int PowerFunction(int x) {
            return (int)(Math.Pow(x, 2) - 4);
        }

        public void Exo3() {
            int res = 0;
            for (int i = -3; i <= 3; i++) {
                try {
                    res = 10/PowerFunction(i);
                    Console.WriteLine(res);
                }
                catch (Exception e) {
                    Console.WriteLine($"Exception caught for i = {i}.", e);
                }
            }
        }
    }
}