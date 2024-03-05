using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DatingDB.Data;
using DatingDB.Services;
using DatingDB.Components;

namespace DatingDB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<DatingDBContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DatingDBContext") ?? throw new InvalidOperationException("Connection string 'DatingDBContext' not found.")));

            builder.Services.AddQuickGridEntityFrameworkAdapter();

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddScoped<UserService, UserService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
