using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using workspace.Context;
using workspace.Context.DTO;
using workspace.Models;

namespace workspace.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class VideosController : ControllerBase
  {
    private readonly ILogger<VideosController> _logger;
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    public VideosController(DatabaseContext context, ILogger<VideosController> logger, IMapper mapper)
    {
      _logger = logger;
      _context = context;
      _mapper = mapper;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var videos = await _context.Videos.AsNoTracking().ToListAsync();
      return Ok(videos);
    }

    [HttpPost]
    public async Task<IActionResult> CreateVideo([FromBody] CreateVideoDTO newVideo)
    {
      Videos video = _mapper.Map<Videos>(newVideo);
      await _context.Videos.AddAsync(video);
      await _context.SaveChangesAsync();
      return Ok(video);
    }
  }
}
