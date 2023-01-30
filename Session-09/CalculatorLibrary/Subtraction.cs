namespace CalculatorLibrary
{
    public class Subtraction
    {
        public decimal Do(decimal? x, decimal? y)
        {

            decimal ret = 0;

            if (x != null && y != null)
            {
                ret = x.Value - y.Value;
            }

            return ret;
        }

    }
}