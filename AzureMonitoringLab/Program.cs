var builder = WebApplication.CreateBuilder(args);

// 🔥 THIS LINE FORCES APPLICATION INSIGHTS (no portal guessing)
builder.Services.AddApplicationInsightsTelemetry();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapGet("/", () => "Azure Monitoring Lab is running!");

app.Run();
