using System;

namespace ConsoleApplication1
{
    public class Exercice1
    {
        private int AskUserForParameter() {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        
        public void Exo1Part1(){
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("Table of "+i+" :");
                for (int j = 1; j <= 10; j++){
                    Console.Write(i+"*"+j+"="+i*j+"\n");
                }
                Console.Write("\n");
            }
        }

        public void Exo1Part2() {
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"Table of  {i} :");
                for (int j = 1; j <= 10; j++) {
                    if (i * j % 2 != 0)
                        Console.Write($"{i}*{j} = {i * j}\n");
                }
                Console.WriteLine();
            }
        }

        public void Exo1Part3() {
            int number = AskUserForParameter();
            Console.WriteLine($"Table of  {number} :");
            for (int j = 1; j <= 10; j++) {
                Console.Write($"{number}*{j} = {number * j}\n");
            }
        }
    }
}