﻿var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
IApplicationBuilder applicationBuilder = app.UseStaticFiles();

app.Run();

