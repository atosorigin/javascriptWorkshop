using System.Web.Mvc;

namespace JavaScript.Workshop.Areas.AdvancedJavascript
{
    public class AdvancedJavascriptAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "AdvancedJavascript";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "AdvancedJavascript_default",
                "AdvancedJavascript/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
