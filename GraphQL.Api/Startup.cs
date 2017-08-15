using GraphQL.Api.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GraphQL.Api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddSingleton<IConfiguration>(
                c => { return Configuration; }
            );

            services.AddTransient<IGraphQLSchemaProvider, GraphQLSchemaProvider>();

            // Add framework services.
            services.AddMvc();

            services.AddEntityFramework();

            services.AddDbContext<GraphQL.Model.AdventureWorksDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]);
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            //app.UseDefaultFiles();


            //app.UseStaticFiles(new StaticFileOptions
            //{
            //    OnPrepareResponse = (context) =>
            //    {
            //        // Disable caching for all static files.
            //        //context.Context.Response.Headers["Cache-Control"] = Configuration["StaticFiles:Headers:Cache-Control"];
            //        //context.Context.Response.Headers["Pragma"] = Configuration["StaticFiles:Headers:Pragma"];
            //        //context.Context.Response.Headers["Expires"] = Configuration["StaticFiles:Headers:Expires"];
            //    }
            //});

            app.UseMvc();
        }
    }
}
