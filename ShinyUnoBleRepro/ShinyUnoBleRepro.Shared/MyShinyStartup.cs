using Microsoft.Extensions.DependencyInjection;
using Shiny;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShinyUnoBleRepro.Shared
{
    public class MyShinyStartup : Shiny.ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            // for general client functionality
            services.UseBleClient();
        }
    }
}
