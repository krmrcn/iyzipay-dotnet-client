﻿using Iyzipay.Model;
using System;
using System.Collections.Generic;

namespace Iyzipay.Request
{
    public class CreatePaymentRequest : BaseRequest
    {
        public decimal? Price { get; set; }
        public decimal? PaidPrice { get; set; }
        public int? Installment { get; set; }
        public String PaymentChannel { get; set; }
        public String BasketId { get; set; }
        public String PaymentGroup { get; set; }
        public String PaymentSource { get; set; }
        public PaymentCard PaymentCard { get; set; }
        public Buyer Buyer { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
        public List<BasketItem> BasketItems { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .AppendPrice("price", Price)
                .AppendPrice("paidPrice", PaidPrice)
                .Append("installment", Installment)
                .Append("paymentChannel", PaymentChannel)
                .Append("basketId", BasketId)
                .Append("paymentGroup", PaymentGroup)
                .Append("paymentSource", PaymentSource)
                .Append("paymentCard", PaymentCard)
                .Append("buyer", Buyer)
                .Append("shippingAddress", ShippingAddress)
                .Append("billingAddress", BillingAddress)
                .AppendList("basketItems", BasketItems)
                .GetRequestString();
        }
    }
}