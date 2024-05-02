using System.Drawing.Text;

namespace CodeDriversMVC.Helpers
{
    public static class CarPriceValidationHelper
    {
        public static bool IsPriceBelowMinimum(decimal minimalPrice, decimal price)
        {
            return price < minimalPrice;
        }
    }
}
