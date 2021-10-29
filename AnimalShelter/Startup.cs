using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Versioning;
using System.Reflection;
using System.IO;
using System;
using AnimalShelter.Models;

namespace AnimalShelter
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
      services.AddControllers();
      services.AddApiVersioning(x =>
      {
              //x.DefaultApiVersion = new ApiVersion(1, 0);
              x.AssumeDefaultVersionWhenUnspecified = true;
        x.ReportApiVersions = true;
              //x.ApiVersionReader = new HeaderApiVersionReader("x-api-version");
            });


      services.AddSwaggerGen(options =>
      {
        options.SwaggerDoc("v1",
                  new Microsoft.OpenApi.Models.OpenApiInfo
              {
                Title = "Animal Shelter",
                Description = "Documentation Provided by Swagger",
                Version = "v1"
              });

        var fileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var filePath = Path.Combine(AppContext.BaseDirectory, fileName);
        options.IncludeXmlComments(filePath);

        options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
      });

      // services.AddApiVersioning(o => {
      // o.ReportApiVersions = true;
      // o.AssumeDefaultVersionWhenUnspecified = true;
      // o.DefaultApiVersion = new ApiVersion(1, 0);
      // });

      services.AddDbContext<AnimalShelterContext>(opt =>
          opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
      services.AddControllers();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });

      app.UseSwagger();

      app.UseSwaggerUI(options =>
      {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Animal Shelter API");
              options.RoutePrefix = "";
            });
    }
  }
}
