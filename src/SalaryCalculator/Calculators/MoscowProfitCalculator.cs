namespace SalaryCalculator.Calculators
{
    public class MoscowProfitCalculator : RussiaProfitCalculator
    {
        public override string Name
        {
            get { return "Moscow"; }
        }

        protected override double? HabitationCost
        {
            get { return 38000; }
        }
    }
}
