using CarProject.Data;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CarProject.API.Controllers
{
    public class VehiclesController : ODataController
    {
        private CarProjectDbContext _ctx = new CarProjectDbContext();

        [HttpGet]
        [ODataRoute("Cars")]
        public IHttpActionResult GetAllVehicles()
        {
            return Ok(_ctx.Automobile);
        }

        [HttpGet]
        [ODataRoute("Cars({key})")]

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
            base.Dispose(disposing);
        }
    }
}