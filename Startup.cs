using System;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AstartesCodexProject.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using AstartesCodexProject.Repositories;

namespace AstartesCodexProject
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
      services.AddCors(options =>
                {
                  options.AddPolicy("CorsDevPolicy", builder =>
                        {
                          builder
                                    .WithOrigins(new string[]{
                                "http://localhost:8080"
                                })
                                    .AllowAnyMethod()
                                    .AllowAnyHeader()
                                    .AllowCredentials();
                        });
                });
      services.AddMvc();
      // TODO register all Transient informations
      services.AddTransient<IDbConnection>(x => CreateDBContext());
      services.AddTransient<PrimarchRepository>();
      services.AddTransient<LegionRepository>();
      services.AddTransient<NotableAstartesRepository>();




    }

    private IDbConnection CreateDBContext()
    {
      var _connectionString = Configuration.GetSection("DB").GetValue<string>("gearhost");
      var connection = new MySqlConnection(_connectionString);
      connection.Open();
      return connection;
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseCors("CorsDevPolicy");
      }
      else
      {
        app.UseHsts();
      }
      //NOTE I dont remember what UseHttpsRedirection is but it was in the reference so better safe than sorry (shrug)
      // app.UseHttpsRedirection();

      app.UseDefaultFiles();
      app.UseStaticFiles();
      app.UseMvc();
    }
  }
}
