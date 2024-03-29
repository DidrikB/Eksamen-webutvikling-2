#nullable disable
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MilitaryApi.Models;

namespace MilitaryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SoldierController : ControllerBase
{
    private readonly MilitaryContext _context;

    public SoldierController(MilitaryContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Soldier>>> Get()
    {
        List<Soldier> soldiers = await _context.Soldiers.ToListAsync();
        return soldiers;
    }

    [HttpPost]
    public async Task<IActionResult> Post(Soldier soldier)
    {
        _context.Soldiers.Add(soldier);
        await _context.SaveChangesAsync();
        return StatusCode(200);
    }
}