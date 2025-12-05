using Microsoft.AspNetCore.Identity; // Needed for Identity logic
using Microsoft.EntityFrameworkCore; // Needed for SQL logic
using SpellSinger.Data;
using SpellSinger.Domain; // Needed to find your 'User' class

var builder = WebApplication.CreateBuilder(args);


AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddIdentity<User, IdentityRole<Guid>>(options =>
{
    // Relaxed password rules for development
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 4;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
})
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders()
    .AddDefaultUI(); 

// --- 3. Web Services ---
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// --- 4. The Pipeline ---
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

// --- 5. Security Middleware ---
app.UseAuthentication(); // Who are you?
app.UseAuthorization();  // Are you allowed in?

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

// Map the Login/Register pages
app.MapRazorPages();

app.Run();