using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using web_api.Database;
using web_api.Database.Models;

namespace web_api.Controllers;

[ApiController]
[Route("/api")]
public class WebApiController : ControllerBase
{
    private readonly DatabaseContext _db;
    private readonly IMapper _mapper;
    private readonly ILogger<WebApiController> _logger;

    public WebApiController(DatabaseContext db, ILogger<WebApiController> logger)
    {
        _db = db;
        _logger = logger;
    }
    
    [HttpGet, Route("get_users")]
    public IActionResult GetUser()
    {
        return Ok(_db.Users);
    }
    
    [HttpPost, Route("put_user")]
    public IActionResult PostUser(string name, int age)
    {
        web_api.Database.Models.UserMod tmp = new UserMod()
        {
            //Id = _db.Users.Count(),
            Age = age,
            Name = name
        };
        
        _db.Users.Add(tmp);
        _db.SaveChanges();
        return Ok();
    }
}