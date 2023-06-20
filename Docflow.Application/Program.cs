WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.AddFlowOptions();

builder.Services.AddFastEndpoints();
builder.Services.AddSwaggerDoc();
builder.Services.AddGateways();
builder.Services.AddCommunicators();

WebApplication app = builder.Build();

app.UseHttpsRedirection();
app.UseFastEndpoints();
app.UseOpenApi();
app.UseSwaggerUi3(s => s.ConfigureDefaults());

app.MapGet("/", () => Results.Redirect("/swagger"));

app.Run();
