using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScreenplayVisualization.Application.Common.Interfaces;
using ScreenplayVisualization.Application.Models;
using ScreenplayVisualization.Domain.Entities;
using ScreenplayVisualization.Infrastructure.Persistence.Contexts;
using ScreenplayVisualization.Infrastructure.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IRepository<Scene>, Repository<Scene>>();

var app = builder.Build();

app.MapGet("api/scenes", async ([FromServices] IRepository<Scene> scenesRepository) =>
{
    var scenes = await scenesRepository.GetAll().ProjectToType<SceneDto>().ToListAsync();
    return new GetScenesResponse { Scenes = scenes };
});

app.Run();