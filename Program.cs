using StrategyProject.Domain;

namespace StrategyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var strategy = new CalculatorContext();

            while (true)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Type the first value");
                double valor1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Type the second value");
                double valor2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1 - Add");
                Console.WriteLine("2 - Subtract");
                Console.WriteLine("3 - Divide");
                Console.WriteLine("4 - Multiply");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        {
                            strategy.Calculator = new AddConcreteStrategy();
                            strategy.Execute(valor1, valor2);
                            break;
                        }
                    case "2":
                        {
                            strategy.Calculator = new SubtractConcreteStrategy();
                            strategy.Execute(valor1, valor2);
                            break;
                        }
                    case "3":
                        {
                            strategy.Calculator = new DivideConcreteStrategy();
                            strategy.Execute(valor1, valor2);
                            break;
                        }
                    case "4":
                        {
                            strategy.Calculator = new MultiplyConcreteStrategy();
                            strategy.Execute(valor1, valor2);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("The operation is invalid.");
                            break;
                        }
                }
            }
        }
    }
}
