﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testwebapp.Startup))]
namespace testwebapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
