using CarProject.Data.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CarProject.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.MapODataServiceRoute("ODataRoute", "odata", GetEdmModel());

            config.EnsureInitialized();
        }

        private static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.Namespace = "CarProject";
            builder.ContainerName = "CarProjectContainer";

            builder.EntitySet<Driver>("Drivers");
            builder.EntitySet<Automobile>("Cars");

            return builder.GetEdmModel();
        }
    }

    
}
