namespace rediscachedemoazure.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public List<Account>? userAccounts { get; set; }
    }
}
