namespace SalaryCalculator.Calculators
{
    public class KrasnodarProfitCalculator : RussiaProfitCalculator
    {
        public override string Name
        {
            get { return "Krasnodar"; }
        }

        protected override double? HabitationCost
        {
            get { return 20000; }
        }
    }
}
