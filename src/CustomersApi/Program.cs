using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;

//C# 9
WebHost.CreateDefaultBuilder().Configure(app =>
{
    //Route-to-code (.NET 5) <=> Minimal APIs (.NET 6)
    app.UseRouting();

    //Middleware
    app.UseEndpoints(e =>
    {
        //Request <-> Response 
        e.MapGet("/", c => c.Response.WriteAsync("Hello world!"));
        e.MapGet("hello/{name}", c => c.Response.WriteAsync($"Hello, {c.Request.RouteValues["name"]}"));
        e.MapGet("api/v1/customers", c => c.Response.WriteAsync($"Hello, {Array.Empty<object>()}"));
    });
}).Build().Run();
