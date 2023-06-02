using Serenity.Services;

namespace SMarketPlace.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}