using GraphQL.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;

namespace GraphQL.Api.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly AdventureWorksDbContext _adventureWorksDbContext;

        public EmployeesController(AdventureWorksDbContext adventureWorksDbContext)
        {
            _adventureWorksDbContext = adventureWorksDbContext;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(_adventureWorksDbContext.Employees.ToList(), new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            });
        }
    }
}
