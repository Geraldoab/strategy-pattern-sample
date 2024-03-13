namespace StrategyProject.Domain
{
    public class SubtractConcreteStrategy : CalculatorStrategy
    {
        public override double Operation(double v1, double v2)
        {
            return v1 - v2;
        }
    }
}
