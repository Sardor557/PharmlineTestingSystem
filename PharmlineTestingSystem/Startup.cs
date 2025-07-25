﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using PharmlineTestingSystem.Extensions;
using PharmlineTestingSystem.ViewModels;
using PharmlineTestingSystem.Repository;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using ZNetCS.AspNetCore.Compression;
using ZNetCS.AspNetCore.Compression.Compressors;

[assembly: ApiController]
namespace PharmlineTestingSystem
{
    public sealed class Startup
    {
        public IConfiguration conf { get; }
        public Startup(IConfiguration configuration) => conf = configuration;


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.Configure<Vars>(conf.GetSection("SystemVars"));

            services.AddCompression(options => { options.Compressors = new List<ICompressor> { new GZipCompressor(CompressionLevel.Fastest), new DeflateCompressor(CompressionLevel.Fastest), new BrotliCompressor(CompressionLevel.Fastest) }; });

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders",
                        builder =>
                        {
                            builder.AllowAnyOrigin()
                                   .AllowAnyHeader()
                                   .AllowAnyMethod();
                        });
            });

            services.AddMyServices();
            services.AddMyDatabaseService(conf);

            services.AddControllers().AddNewtonsoftJson(opt =>
            {
                opt.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });

            services.AddMemoryCache();
            services.AddMyAuthentication(conf);
            services.AddMySwagger();
            services.AddHttpContextAccessor();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!env.IsDevelopment())            
                app.UseExceptionHandler("/Error");

            app.UseCompression();
            app.UseDeveloperExceptionPage();

            app.UseRequestLocalization();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors("AllowAllHeaders");
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGet("/", async context =>
                {
                    context.Response.ContentType = "text/html";
                    await context.Response.SendFileAsync(Path.Combine(env.WebRootPath, "index.html"));
                });

            });

            app.UseSerilogRequestLogging();
            app.UseMySwagger();

            app.UpdateMigrateDatabase();
        }
    }
}
