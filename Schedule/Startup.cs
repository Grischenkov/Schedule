using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Schedule.ModelInterfaces;
using Schedule.ModelMocks;

namespace Schedule
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore();

            services.AddTransient<IClass, MockClass>();
            services.AddTransient<IClassroom, MockClassroom>();
            services.AddTransient<IDay, MockDay>();
            services.AddTransient<IFaculty, MockFaculty>();
            services.AddTransient<IGroup, MockGroup>();
            services.AddTransient<ILesson, MockLesson>();
            services.AddTransient<ISchedule, MockSchedule>();
            services.AddTransient<IStudent, MockStudent>();
            services.AddTransient<ITeacher, MockTeacher>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
        }
    }
}
