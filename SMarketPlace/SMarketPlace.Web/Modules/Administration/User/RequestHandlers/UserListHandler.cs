using Serenity.Services;
using MyRequest = SMarketPlace.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<SMarketPlace.Administration.UserRow>;
using MyRow = SMarketPlace.Administration.UserRow;

namespace SMarketPlace.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}