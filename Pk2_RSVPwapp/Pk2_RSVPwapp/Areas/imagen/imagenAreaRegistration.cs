using System.Web.Mvc;

namespace Pk2_RSVPwapp.Areas.imagen
{
    public class imagenAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "imagen";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "imagen_default",
                "imagen/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
