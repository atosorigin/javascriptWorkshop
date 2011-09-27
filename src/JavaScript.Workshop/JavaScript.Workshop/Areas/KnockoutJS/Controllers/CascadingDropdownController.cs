using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JavaScript.Workshop.Areas.KnockoutJS.Models;

namespace JavaScript.Workshop.Areas.KnockoutJS.Controllers
{
    public class CascadingDropdownController : Controller
    {
        //
        // GET: /KnockoutJS/CascadingDropdown/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult States(string country)
        {
            var states = GetStates().Where(s => s.Country == country);
            return new JsonResult { Data = states, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult Cities(string state)
        {
            var states = GetCities().Where(s => s.State == state);
            return new JsonResult { Data = states, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        private IEnumerable<CityModel> GetCities()
        {
            yield return new CityModel { State = "nlli", City = "Maastricht" };
            yield return new CityModel { State = "nlli", City = "Heerlen" };
            yield return new CityModel { State = "nlgr", City = "Groningen" };
            yield return new CityModel { State = "nlut", City = "Utrecht" };
            yield return new CityModel { State = "usfl", City = "Miami" };
            yield return new CityModel { State = "usca", City = "Los Angeles" };
            yield return new CityModel { State = "usca", City = "San Francisco" };
        }

        private IEnumerable<StateModel> GetStates()
        {
            yield return new StateModel { Country = "nl", StateCode = "nlli", StateName = "Limburg" };
            yield return new StateModel { Country = "nl", StateCode = "nlgr", StateName = "Groningen" };
            yield return new StateModel { Country = "nl", StateCode = "nlfr", StateName = "Friesland" };
            yield return new StateModel { Country = "nl", StateCode = "nlut", StateName = "Utrecht" };
            yield return new StateModel { Country = "us", StateCode = "usfl", StateName = "Florida" };
            yield return new StateModel { Country = "us", StateCode = "usne", StateName = "Nevada" };
            yield return new StateModel { Country = "us", StateCode = "usca", StateName = "Califonia" };
            yield return new StateModel { Country = "us", StateCode = "usar", StateName = "Arizona" };
            yield return new StateModel { Country = "de", StateCode = "dehe", StateName = "Hesse" };
            yield return new StateModel { Country = "de", StateCode = "deba", StateName = "Bavaria" };
            yield return new StateModel { Country = "de", StateCode = "debr", StateName = "Brandenburg" };
            yield return new StateModel { Country = "de", StateCode = "debe", StateName = "Berlin" };
            yield return new StateModel { Country = "de", StateCode = "desa", StateName = "Saarland" };
            yield return new StateModel { Country = "de", StateCode = "deha", StateName = "Hamburg" };
        }
    }
}
