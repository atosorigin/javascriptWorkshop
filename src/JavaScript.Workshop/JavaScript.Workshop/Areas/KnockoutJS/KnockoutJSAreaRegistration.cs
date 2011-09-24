using System.Web.Mvc;

namespace JavaScript.Workshop.Areas.KnockoutJS
{
    public class KnockoutJSAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "KnockoutJS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "KnockoutJS_default",
                "KnockoutJS/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
