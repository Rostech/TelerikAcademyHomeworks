namespace Abstraction
{
    public static class NumberValidation
    {
        public static bool IsGreaterThanZero(double number)
        {
            if(number <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
