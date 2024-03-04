using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFzad1
{
    internal class CouponMachine
    {
        private List<string> coupons = new List<string>();
        private Random random = new Random();

        public void AddCoupon(string coupon)
        {
            coupons.Add(coupon);
        }

        public string DrawCoupon()
        {
            if (coupons.Count == 0)
            {
                throw new InvalidOperationException("Brak dostępnych kuponów.");
            }

            int index = random.Next(coupons.Count);
            string drawnCoupon = coupons[index];
            coupons.RemoveAt(index);
            return drawnCoupon;
        }

        public bool AnyCouponsAvailable()
        {
            return coupons.Count > 0;
        }

        public List<string> ViewAllCoupons()
        {
            return coupons;
        }
    }
}
