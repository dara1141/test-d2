var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//ffff
branch 2
riadok 17 middle point
    riadok 18
/////

branch 2

branch 3
    brachn 2
    branch 3 top
//darka zmena
//darka zmena 2
/////
///
///6666da
///dd

//**

//22.08 3
//22

// 22.08
// 22.08 2

// zmena 1

// zmena 2

// zmena 4

// zmena 4 b

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
