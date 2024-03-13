namespace StrategyProject.Domain
{
    public class DivideConcreteStrategy : CalculatorStrategy
    {
        public override double Operation(double v1, double v2)
        {
            if (v2 == 0)
                throw new DivideByZeroException();

            return v1 / v1;
        }
    }
}
