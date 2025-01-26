var builder = WebApplication.CreateBuilder(args);

// Adicionar serviços para MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurar o pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
