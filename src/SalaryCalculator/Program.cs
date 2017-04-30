using System.Collections.Generic;
using System.IO;
using System.Text;
using SalaryCalculator.Calculators;
using SalaryCalculator.Currencies;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ProfitCalculator[] profitCalculators = {
                new NiznyNovgorodProfitCalculator(),
                new MoscowProfitCalculator(), 
                new KrasnodarProfitCalculator(), 
                new WroclawProfitCalculator(),
            };
            var ruble = new Ruble();

            foreach (var profitCalculator in profitCalculators)
            {
                var currency = profitCalculator.Currency;
                var salaryByProfit = new Dictionary<double, double>();
                for (int profit = currency.LowerLimit; profit <= currency.UpperLimit; profit += currency.Step)
                {
                    var salary = profitCalculator.CalculateProfit(profit);
                    salaryByProfit[profit] = salary;
                }

                var fileName = $"{profitCalculator.Name}.csv";
                using (var streamWriter = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    foreach (var pair in salaryByProfit)
                    {
                        var profit = pair.Key;
                        var salary = pair.Value;
                        streamWriter.WriteLine("{0} {1};{2} {3}", profit, currency.Sign, salary, ruble.Sign);
                    }
                }
            }
        }
    }
}
