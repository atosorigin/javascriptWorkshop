using System.Web.Mvc;

namespace JavaScript.Workshop.Areas.JQueryUI
{
    public class JQueryUIAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "JQueryUI";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "JQueryUI_default",
                "JQueryUI/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
