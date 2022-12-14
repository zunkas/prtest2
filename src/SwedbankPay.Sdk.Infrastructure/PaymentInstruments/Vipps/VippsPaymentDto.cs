using System;

namespace SwedbankPay.Sdk.PaymentInstruments.Vipps
{
    internal class VippsPaymentDto
    {
        public long Amount { get; set; }
        public VippsPaymentAuthorizationListResponseDto Authorizations { get; set; }
        public CancellationListResponseDto Cancellations { get; set; }
        public CaptureTransactionResponseDto Captures { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public string Instrument { get; set; }
        public string Intent { get; set; }
        public string Language { get; set; }
        public long Number { get; set; }
        public string Operation { get; set; }
        public PayeeInfoResponseDto PayeeInfo { get; set; }
        public string PayerReference { get; set; }
        public string InitiatingSystemUserAgent { get; set; }
        public PriceListResponseDto Prices { get; set; }
        public ReversalListResponseDto Reversals { get; set; }
        public string State { get; set; }
        public TransactionListResponseDto Transactions { get; set; }
        public UrlsDto Urls { get; set; }
        public string UserAgent { get; set; }
        public MetadataDto Metadata { get; set; }
        public int VatAmount { get; internal set; }
        public int RemainingReversalAmount { get; set; }
        public int RemainingCaptureAmount { get; set; }
        public int RemainingCancellationAmount { get; set; }
    }
}