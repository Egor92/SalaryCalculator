using SalaryCalculator.Currencies;

namespace SalaryCalculator.Calculators
{
    public class WroclawProfitCalculator : ProfitCalculator
    {
        public override string Name
        {
            get { return "Wroclaw"; }
        }

        protected override double? HabitationCost
        {
            get { return 2200; }
        }

        public override ICurrency Currency
        {
            get { return new Zloty(); }
        }

        protected override double CalculateMonthTax(double salary)
        {
            const int monthsPerYear = 12;
            var yearEarning = salary* monthsPerYear;
            const double salaryTaxLimit = 85528.0;
            double yearTax;
            if (yearEarning < salaryTaxLimit)
            {
                yearTax = yearEarning * 0.18 - 556.02;
            }
            else
            {
                const double firstTaxPart = salaryTaxLimit * 0.18 - 556.02;
                var secondTaxPart = (yearEarning - salaryTaxLimit)*0.32;
                yearTax = firstTaxPart + secondTaxPart;
            }
            return yearTax / monthsPerYear;
        }
    }
}
