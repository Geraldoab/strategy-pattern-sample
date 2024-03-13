namespace StrategyProject.Domain
{
    public class CalculatorContext
    {
        public CalculatorStrategy Calculator { get; set; }

        public void Execute(double valor1, double valor2)
        {
            Console.WriteLine($"Result => {Calculator.Operation(valor1, valor2)}");
        }
    }
}
