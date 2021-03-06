﻿using Armut.Iyzipay.Request;

namespace Armut.Iyzipay.Tests.Functional.Builder.Request
{
    public class CreatePeccoPaymentRequestBuilder : BaseRequestBuilder<CreatePeccoPaymentRequest>
    {
        private string _token;

        private CreatePeccoPaymentRequestBuilder()
        {
        }

        public static CreatePeccoPaymentRequestBuilder Create()
        {
            return new CreatePeccoPaymentRequestBuilder();
        }

        public CreatePeccoPaymentRequestBuilder Token(string token)
        {
            _token = token;
            return this;
        }

        public override CreatePeccoPaymentRequest Build()
        {
            CreatePeccoPaymentRequest createPeccoPaymentRequest = new CreatePeccoPaymentRequest {Token = _token};
            return createPeccoPaymentRequest;
        }
    }
}
