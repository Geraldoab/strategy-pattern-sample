namespace StrategyProject.Domain
{
    public class MultiplyConcreteStrategy : CalculatorStrategy
    {
        public override double Operation(double v1, double v2)
        {
            return v1 * v2;
        }
    }
}
