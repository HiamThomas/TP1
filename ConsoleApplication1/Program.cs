using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static int AskUserForParameter() {
            Console.Write("Write a number between 0 and 9:");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        public static void Menu() {
            int choice;
            do {
                Console.WriteLine();
                Console.WriteLine("1/ Exercice 1 Partie 1");
                Console.WriteLine("2/ Exercice 1 Partie 2");
                Console.WriteLine("3/ Exercice 1 Partie 3");
                Console.WriteLine("4/ Exercice 2 Partie 1");
                Console.WriteLine("5/ Exercice 2 Partie 2");
                Console.WriteLine("6/ Exercice 2 Partie 3");
                Console.WriteLine("7/ Exercice 3");
                Console.WriteLine("8/ Exercice 4");
                Console.WriteLine("9/ Exercice 5");
                Console.WriteLine("0/ Quitter");
                Console.WriteLine();
                choice = AskUserForParameter();
                switch (choice) {
                    case 1:
                        Exercice1 exo1 = new Exercice1();
                        exo1.Exo1Part1();
                        break;

                    case 2:
                        Exercice1 exo12 = new Exercice1();
                        exo12.Exo1Part2();
                        break;

                    case 3:
                        Exercice1 exo13 = new Exercice1();
                        exo13.Exo1Part3();
                        break;

                    case 4:
                        Exercice2 exo21 = new Exercice2();
                        exo21.Exo2Part1();
                        break;
                    case 5:
                        Exercice2 exo22 = new Exercice2();
                        exo22.Exo2Part2();
                        break;
                    
                    case 6:
                        Exercice2 exo23 = new Exercice2();
                        exo23.Exo2Part3();
                        break;
                    
                    case 7:
                        Exercice3 exo3 = new Exercice3();
                        exo3.Exo3();
                        break;
                    
                    case 8:
                        Exercice4 exo4 = new Exercice4();
                        exo4.Exo4();
                        break;
                    
                    case 9:
                        Exercice5 exo5 = new Exercice5();
                        exo5.Exo5();
                        break;
                }
            } while (choice != 0);
        }

        public static void Main(string[] args) {
            Menu();
        }
    }
}