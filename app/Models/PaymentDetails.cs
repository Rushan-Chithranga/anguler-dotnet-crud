namespace PaymentAPI.Models
{
    public class PaymentDetails
    {
        [key]
        public int PaymentDetails { get; set; }

        public string CardOwnerName { get; set; }

        public string CardNumber { get; set; }

        public string ExpirationDate { get; set; }

        public string SecurityCode { get; set; }
    }
}