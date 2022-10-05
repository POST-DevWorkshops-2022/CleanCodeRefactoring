using System.Linq;

namespace CleancodeKata.stage4
{
    /**
     * Make this code clean.
     */
    public class Stage4
    {
        public double Compute(double[] productPrices, bool vip, bool blackFriday)
        {
            double total = productPrices.Sum();
            var discount = ComputeDiscount(productPrices.Length, vip, blackFriday);
            var discountAmount = discount * total / 100;
            return total - discountAmount;
        }

        public int ComputeDiscount(int numberOfProducts, bool vip, bool blackFriday)
        {
            var percent = 0;
            if (numberOfProducts >= 5 && numberOfProducts < 10)
            {
                percent += 4;
            }
            else if (numberOfProducts >= 10)
            {
                percent += 10;
            }

            if (blackFriday)
            {
                // black friday discount
                percent += 20;
            }

            if (vip)
            {
                // vip client
                percent += 5;
            }

            return percent;
        }
    }
}