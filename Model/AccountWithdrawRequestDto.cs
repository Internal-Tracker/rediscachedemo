namespace rediscachedemoazure.Model
{
    public class AccountWithdrawRequestDto
    {
        public int UserId { get; set; }
        public string? AccountNumberToWithdrawFrom { get; set; }
        public decimal WithdrawAmount { get; set; }
    }
}
