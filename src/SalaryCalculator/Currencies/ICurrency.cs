namespace SalaryCalculator.Currencies
{
    public interface ICurrency
    {
        string Sign { get; }

        int LowerLimit { get; }

        int UpperLimit { get; }

        int Step { get; }

        double ConvertToRubles(double value);
    }
}
