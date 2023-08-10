namespace rediscachedemoazure.Model
{
    public class Account
    {
        public int AccountID { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountOpeningDate { get; set; }
        public string? AccountStatus { get; set; }
        public decimal AccountBalance { get; set; }
        // public User? User { get; set; }
    }
}
