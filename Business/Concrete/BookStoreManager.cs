using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookStoreManager
    {
        public PurchaseResponse HandlePurchase(PurchaseRequest request)
        {
            decimal discount = CalculateDiscount(request.CustomerType, request.TotalAmount);
            decimal discountedAmount = request.TotalAmount * discount;
            decimal finalPrice = request.TotalAmount - discountedAmount;

            return new PurchaseResponse
            {
                OriginalPrice = request.TotalAmount,
                DiscountedAmount = discountedAmount,
                FinalPrice = finalPrice
            };
        }

        public decimal CalculateDiscount(CustomerType customerType, decimal totalAmount)
        {
            switch (customerType)
            {
                case CustomerType.Regular:
                    return 0;
                case CustomerType.Premium:
                    return totalAmount > 100 ? 0.10m : 0;
                case CustomerType.Employee:
                    return 0.30m;
                default:
                    return 0;
            }
        }

    }
}
