namespace StrategyProject.Domain
{
    public class AddConcreteStrategy : CalculatorStrategy
    {
        public override double Operation(double v1, double v2)
        {
            return v1 + v2;
        }
    }
}
