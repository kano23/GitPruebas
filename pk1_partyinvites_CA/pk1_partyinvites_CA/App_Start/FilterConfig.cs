using System.Web;
using System.Web.Mvc;

namespace pk1_partyinvites_CA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}