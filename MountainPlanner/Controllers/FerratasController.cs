using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MountainPlanner.Data;
using MountainPlanner.Models;
using System.Diagnostics;

namespace MountainPlanner.Controllers;

public class FerratasController : Controller
{
    private readonly ApplicationDbContext dbContext;
    public FerratasController(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public async Task<IActionResult> Index()
    {
        var ferratas = await dbContext.Ferratas.ToListAsync();
        return View(ferratas);
    }
}
