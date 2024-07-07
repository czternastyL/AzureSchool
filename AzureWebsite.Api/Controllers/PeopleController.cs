using AzureWebsite.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureWebsite.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly ILogger<PeopleController> logger;
    private readonly PeopleDb db;

    public PeopleController(ILogger<PeopleController> logger, PeopleDb db)
    {
        this.logger = logger;
    }

    [HttpGet(Name = "GetPeople")]
    public async Task<IEnumerable<Person>> Get()
    {
       var people = await db.People.ToListAsync();
       return people;
    }
}
