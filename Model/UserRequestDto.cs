namespace rediscachedemoazure.Model
{
    public class UserRequestDto
    {
        public int userID { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal amount { get; set; }
        public string? AccountAction { get; set; }
    }
}
