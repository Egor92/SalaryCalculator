using SalaryCalculator.Currencies;

namespace SalaryCalculator.Calculators
{
    public abstract class ProfitCalculator
    {
        public abstract string Name { get; }

        protected abstract double? HabitationCost { get; }

        public abstract ICurrency Currency { get; }

        protected abstract double CalculateMonthTax(double salary);

        public double CalculateProfit(double salary)
        {
            var monthTax = CalculateMonthTax(salary);
            var netSalary = salary - monthTax;
            var profit = netSalary - HabitationCost.GetValueOrDefault();
            if (Currency != null)
            {
                profit = Currency.ConvertToRubles(profit);
            }
            return profit;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
