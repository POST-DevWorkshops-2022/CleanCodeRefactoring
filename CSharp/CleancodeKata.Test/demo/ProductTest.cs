using System;
using System.Collections.Generic;
using System.Text;
using CleancodeKata.demo;
using Xunit;

namespace CSharpCore.Test
{
    
    public class ProductTest
    {
        [Fact]
        public void PaymentInformationPriceMismatch()
        {
            var paymentApp = new PaymentApp();
            var paymentInfo = paymentApp.getPaymentInformation(new Product(5, true), new Payment(6, true));

            Assert.Equal("Price mismatch", paymentInfo);
        }
        [Fact]
        public void PaymentInformationProductNotInStock()
        {
            var paymentApp = new PaymentApp();
            var paymentInfo = paymentApp.getPaymentInformation(new Product(5, false), new Payment(5, true));

            Assert.Equal("Product not in stock", paymentInfo);
        }
        [Fact]
        public void PaymentInformationPaymentNotMade()
        {
            var paymentApp = new PaymentApp();
            var paymentInfo = paymentApp.getPaymentInformation(new Product(5, true), new Payment(5, false));

            Assert.Equal("Payment is not made. Send to the payment screen.", paymentInfo);
        }
        [Fact]
        public void PaymentInformationPaymentCanBeMade()
        {
            var paymentApp = new PaymentApp();
            var paymentInfo = paymentApp.getPaymentInformation(new Product(5, true), new Payment(5, true));

            Assert.Equal("Place the order", paymentInfo);
        }
    }
}
