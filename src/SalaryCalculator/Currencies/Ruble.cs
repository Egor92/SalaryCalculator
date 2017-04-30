namespace SalaryCalculator.Currencies
{
    public class Ruble : ICurrency
    {
        public string Sign
        {
            get { return "₽"; }
        }

        public int LowerLimit
        {
            get { return 30000; }
        }

        public int UpperLimit
        {
            get { return 200000; }
        }

        public int Step
        {
            get { return 5000; }
        }

        public double ConvertToRubles(double value)
        {
            return value;
        }
    }
}
