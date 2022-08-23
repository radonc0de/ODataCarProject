using CarProject.Data;
using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CarProject.API.Controllers
{
    public class DriversController : ODataController
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