using System.Web.Mvc;

namespace JavaScript.Workshop.Areas.BasicJavascript
{
    public class BasicJavascriptAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "BasicJavascript";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "BasicJavascript_default",
                "BasicJavascript/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
