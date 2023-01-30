namespace CalculatorLibrary
{
    public class Division
    {
        public decimal Do(decimal? x, decimal? y)
        {
            decimal ret = 0;

            if (x != null && y != null)
            {
                if (x != 0 && y != 0)
                {
                    if (y != 0) { 
                        ret = x.Value / y.Value;
                    }
 
                }
            }
            return ret;
        }
    }
}