using SalaryCalculator.Currencies;

namespace SalaryCalculator.Calculators
{
    public abstract class RussiaProfitCalculator : ProfitCalculator
    {
        public override ICurrency Currency
        {
            get { return new Ruble(); }
        }

        protected override double CalculateMonthTax(double salary)
        {
            return salary * 0.13;
        }
    }
}
