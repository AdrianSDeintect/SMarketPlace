using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SMarketPlace.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SMarketPlace.Administration.LanguageRow;


namespace SMarketPlace.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}