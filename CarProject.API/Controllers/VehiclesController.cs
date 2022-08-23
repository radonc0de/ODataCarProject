using CarProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarProject.API.Controllers
{
    public class VehiclesController
    {
        private CarProjectDbContext _ctx = new CarProjectDbContext();

        public IHttpActionResult Get()
        {
            return Ok(_ctx.Driver);
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
            base.Dispose(disposing);
        }
    }
}