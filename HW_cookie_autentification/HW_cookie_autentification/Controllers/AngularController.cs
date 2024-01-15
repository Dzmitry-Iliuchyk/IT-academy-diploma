using Bogus;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace HW_cookie_autentification.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AngularController : ControllerBase
    {
        private readonly IDistributedCache _cache;
        public AngularController(IDistributedCache cache)
        {
            _cache = cache;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _cache.GetStringAsync("key");


            if (data != null)
            {
                var result = JsonSerializer.Deserialize<testdata[]>(data);

                return Ok(result);
            }

            var faker = new Faker<testdata>()
                .RuleFor(x => x.id, _ => Guid.NewGuid())
                .RuleFor(x => x.name, f => f.Name.FullName())
                .RuleFor(x => x.story, f => f.Lorem.Paragraph(2));
            var fakeData = faker.Generate(5);

            
            var json = JsonSerializer.Serialize(fakeData);
    
            var options = new DistributedCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(30));

            await _cache.SetStringAsync("key", json, options);

            return Ok(fakeData);

        }
        public class WeatherForecast
        {
            public DateTimeOffset Date { get; set; }
            public int TemperatureCelsius { get; set; }
            public string? Summary { get; set; }
        }

    }

    public class testdata
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string story { get; set; }
    };
}
