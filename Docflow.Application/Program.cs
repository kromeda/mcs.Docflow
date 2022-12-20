WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.AddFlowOptions();

builder.Services.AddFastEndpoints();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDiadocApiGateway, DiadocApiGateway>();

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
