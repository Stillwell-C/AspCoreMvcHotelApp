using UseCases.HotelsUseCases;
using UseCases.Interfaces;
using UseCases.DataStorePluginInterfaces;
using Plugins.DataStore.InMemory;
using UseCases.BookingsUseCases;
using Microsoft.EntityFrameworkCore;
using Plugins.DataStore.SQL;
using Microsoft.AspNetCore.Identity;
using WebApp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AccountContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Booking"));
});
builder.Services.AddDbContext<BookingContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Booking"));
});

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<AccountContext>();

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("BookingAdminstration", p => p.RequireClaim("Position", "BookingAdmin"));
    options.AddPolicy("UserAdministration", p => p.RequireClaim("Position", "UserAdmin"));
});

if( builder.Environment.IsEnvironment("QA") ){
    builder.Services.AddSingleton<IHotelsRepository, HotelsInMemoryRepository>();
    builder.Services.AddSingleton<IBookingsRepository, BookingsInMemoryRepository>();
} else
{
    builder.Services.AddTransient<IHotelsRepository, HotelsSQLRepository>();
    builder.Services.AddTransient<IBookingsRepository, BookingsSQLRepository>();
}

builder.Services.AddTransient<IAddHotelUseCase, AddHotelUseCase>();
builder.Services.AddTransient<IDeleteHotelUseCase, DeleteHotelUseCase>();
builder.Services.AddTransient<IEditHotelUseCase, EditHotelUseCase>();
builder.Services.AddTransient<ISearchHotelsUseCase, SearchHotelsUseCase>();
builder.Services.AddTransient<IViewDealHotelsUseCase, ViewDealHotelsUseCase>();
builder.Services.AddTransient<IViewFiveStarHotelsUseCase, ViewFiveStarHotelsUseCase>();
builder.Services.AddTransient<IViewHotelByIdUseCase, ViewHotelByIdUseCase>();
builder.Services.AddTransient<IViewHotelsByContinentCountUseCase, ViewHotelsByContinentCountUseCase>();
builder.Services.AddTransient<IViewHotelsUseCase, ViewHotelsUseCase>();
builder.Services.AddTransient<IViewPopularHotelsUseCase, ViewPopularHotelsUseCase>();

builder.Services.AddTransient<IAddBookingUseCase, AddBookingUseCase>();
builder.Services.AddTransient<IDeleteBookingUseCase, DeleteBookingUseCase>();
builder.Services.AddTransient<IEditBookingUseCase, EditBookingUseCase>();
builder.Services.AddTransient<IViewBookingByIdUseCase, ViewBookingByIdUseCase>();
builder.Services.AddTransient<IViewBookingsByUserIdUseCase, ViewBookingsByUserIdUseCase>();


var app = builder.Build();

app.UseStaticFiles();


app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );


app.Run();
