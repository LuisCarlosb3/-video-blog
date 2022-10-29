using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using workspace.Context;

namespace workspace.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class VideosController : ControllerBase
  {
    private readonly ILogger<VideosController> _logger;
    private readonly DatabaseContext _context;

    public VideosController(DatabaseContext context, ILogger<VideosController> logger)
    {
      _logger = logger;
      _context = context;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var videos = await _context.Videos.AsNoTracking().ToListAsync();
      return Ok(videos);
    }
  }
}
