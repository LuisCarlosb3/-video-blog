using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using workspace.Context;
using workspace.Models;

namespace workspace.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CategoryController : ControllerBase
  {
    private readonly ILogger<CategoryController> _logger;
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    public CategoryController(DatabaseContext context, ILogger<CategoryController> logger, IMapper mapper)
    {
      _logger = logger;
      _context = context;
      _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      List<Category> categories = await _context.Category.AsNoTracking().ToListAsync();
      return Ok(categories);
    }
  }
}