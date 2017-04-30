namespace SalaryCalculator.Currencies
{
    public class Zloty : ICurrency
    {
        public string Sign
        {
            get { return "zł"; }
        }

        public int LowerLimit
        {
            get { return 2000; }
        }

        public int UpperLimit
        {
            get { return 15000; }
        }

        public int Step
        {
            get { return 250; }
        }

        public double ConvertToRubles(double value)
        {
            return value * 14.68041;
        }
    }
}
