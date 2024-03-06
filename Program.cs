using FribergRentals.Components;
using FribergRentals.Data.Interfaces;
using FribergRentals.Data.Repositories;
using FribergRentals.Data;
using Microsoft.EntityFrameworkCore;
using FribergRentals.Data.Models;
using FribergRentals.Utilities;

namespace FribergRentals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));

            builder.Services.AddTransient<ICar, CarRepo>();
            builder.Services.AddScoped<ICustomer, CustomerRepo>();
            builder.Services.AddTransient<IOrder, OrderRepo>();
            builder.Services.AddTransient<IAdmin, AdminRepo>();
            builder.Services.AddTransient<IUser<User>, UserRepo<User>>();
            builder.Services.AddTransient<ICategory, CategoryRepo>();
            builder.Services.AddTransient<SessionUtilities>();

            builder.Services.AddHttpContextAccessor();

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
