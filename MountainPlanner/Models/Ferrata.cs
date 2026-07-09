using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MountainPlanner.Models;

public class Ferrata
{
    public int Id { get; set; }

    public string Name { get; set; }

    public FerrataDifficulty Difficulty { get; set; }
}
