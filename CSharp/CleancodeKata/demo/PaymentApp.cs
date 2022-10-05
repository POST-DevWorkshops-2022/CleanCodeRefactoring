using System;
using System.Collections.Generic;
using System.Text;
using CSharpCore;

namespace CleancodeKata.demo
{
    public class PaymentApp
    {
        public string getPaymentInformation(Product product, Payment payment)
        {
            if (product.inStock)
            {
                if (payment.made)
                {
                    if (payment.price == product.price)
                    {
                        return "Place the order";
                    }
                    else
                    {
                        return "Price mismatch";
                    }
                }
                else
                {
                    return "Payment is not made. Send to the payment screen.";
                }
            }
            else
            {
                return "Product not in stock";
            }
        }
    }
}
