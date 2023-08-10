namespace rediscachedemoazure.Model
{
    public class LoginResponseDto
    {
        public int UserID { get; set; }
        public List<Account>? userAccounts { get; set; }
    }
}
