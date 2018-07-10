using Practic.Infrastructure.Data;
using Practic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practic.Controllers
{
    public class HomeController : Controller
    {
        //EFGenericRepository<Determine> DetermineRepo = new EFGenericRepository<Determine>(new CarOrdersContext());
        //EFGenericRepository<Add> AddRepo = new EFGenericRepository<Add>(new CarOrdersContext());
        //EFGenericRepository<JobType> JobTypeRepo = new EFGenericRepository<JobType>(new CarOrdersContext());
        //EFGenericRepository<Material> MaterialRepo = new EFGenericRepository<Material>(new CarOrdersContext());
        EFGenericRepository<RouteType> RouteTypeRepo = new EFGenericRepository<RouteType>(new CarOrdersContext());
        //EFGenericRepository<Route> RouteRepo = new EFGenericRepository<Route>(new CarOrdersContext());
        //EFGenericRepository<Weigh> WeighRepo = new EFGenericRepository<Weigh>(new CarOrdersContext());

        public ActionResult Index()
        {
            var routeType = RouteTypeRepo.Get();
            return View(routeType);
        }
        public ActionResult Get()
        {
           var routeType = RouteTypeRepo.Get();
            return View(routeType);
        }
    }
}
