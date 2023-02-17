namespace Calculator
{
    public interface IRomanCalculator
    {
        string IntToRoman(int value);
        string DecimalToRoman(double value);
        int RomanToInt(string value);
    }
}
