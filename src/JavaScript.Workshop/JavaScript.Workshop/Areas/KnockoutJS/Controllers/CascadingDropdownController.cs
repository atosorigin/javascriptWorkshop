using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRouting;

namespace JavaScript.Workshop.Areas.KnockoutJS.Controllers
{
    [RouteArea("KnockoutJS")]
    public class CascadingDropdownController : Controller
    {
        //
        // GET: /KnockoutJS/CascadingDropdown/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Countries()
        {
            var countries = GetCountries();
            return new JsonResult {Data = countries, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
        }

        [GET("States/{country}")]
        public JsonResult States(string country)
        {
            var states = GetStates().Where(s => s.country == country);
            return new JsonResult {Data = states, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
        }

        [GET("Cities/{state}")]
        public JsonResult Cities(string state)
        {
            var states = GetCities().Where(s => s.state == state);
            return new JsonResult {Data = states, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
        }

        private IEnumerable<dynamic> GetCountries()
        {
            yield return new {text = "Netherlands", value = "nl"};
            yield return new {text = "Germany", value = "de"};
            yield return new {text = "United States", value = "us"};
        }

        private IEnumerable<dynamic> GetStates()
        {
            yield return new {country = "nl", value = "nlli", text = "Limburg"};
            yield return new {country = "nl", value = "nlgr", text = "Groningen"};
            yield return new {country = "nl", value = "nlfr", text = "Friesland"};
            yield return new {country = "nl", value = "nlut", text = "Utrecht"};
            yield return new {country = "us", value = "usfl", text = "Florida"};
            yield return new {country = "us", value = "usne", text = "Nevada"};
            yield return new {country = "us", value = "usca", text = "Califonia"};
            yield return new {country = "us", value = "usar", text = "Arizona"};
            yield return new {country = "de", value = "dehe", text = "Hesse"};
            yield return new {country = "de", value = "deba", text = "Bavaria"};
            yield return new {country = "de", value = "debr", text = "Brandenburg"};
            yield return new {country = "de", value = "debe", text = "Berlin"};
            yield return new {country = "de", value = "desa", text = "Saarland"};
            yield return new {country = "de", value = "deha", text = "Hamburg"};
        }

        private IEnumerable<dynamic> GetCities()
        {
            yield return new {state = "nlli", text = "Maastricht", value = 10};
            yield return new {state = "nlli", text = "Heerlen", value = 11};
            yield return new {state = "nlgr", text = "Groningen", value = 12};
            yield return new {state = "nlut", text = "Utrecht", value = 13};
            yield return new {state = "usfl", text = "Miami", value = 14};
            yield return new {state = "usca", text = "Los Angeles", value = 15};
            yield return new {state = "usca", text = "San Francisco", value = 16};
        }
    }

    public static class DynamicLinqExtensions
    {
        public static IEnumerable<dynamic> Where(this object source, Func<dynamic, bool> predicate)
        {
            foreach (dynamic item in source as dynamic)
            {
                if (predicate(item))
                    yield return item;
            }
        }
    }
}
