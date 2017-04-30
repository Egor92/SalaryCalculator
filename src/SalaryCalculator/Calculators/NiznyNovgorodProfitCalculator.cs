namespace SalaryCalculator.Calculators
{
    public class NiznyNovgorodProfitCalculator : RussiaProfitCalculator
    {
        public override string Name
        {
            get { return "Nizny Novgorod"; }
        }

        protected override double? HabitationCost
        {
            get { return null; }
        }
    }
}
