var builder = WebApplication.CreateBuilder(args);

// Добавить сервисы в контейнер.
builder.Services.AddRazorPages();

var app = builder.Build();

// Настроить конвейер обработки HTTP-запросов.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
