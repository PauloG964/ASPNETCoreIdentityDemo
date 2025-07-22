namespace ASPNETCoreIdentityDemo.Models
{
    public class UserClaimsViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<UserClaim> Cliams { get; set; } = new List<UserClaim>();
    }
}