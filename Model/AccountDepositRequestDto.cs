namespace rediscachedemoazure.Model
{
    public class AccountDepositRequestDto
    {
        public int UserId { get; set; }
        public decimal DepositAmount { get; set; }

        public string? AccountTodeposit { get; set; }
    }
}
