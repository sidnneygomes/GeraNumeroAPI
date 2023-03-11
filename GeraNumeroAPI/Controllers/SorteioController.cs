using Microsoft.AspNetCore.Mvc;

namespace GeraNumeroAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SorteioController : Controller
    {
        
        [HttpGet]
        public async Task<IEnumerable<int>> Get() =>
             Enumerable.Range(1, 6).Select(index =>
                Random.Shared.Next(1, 60)
            ).ToArray().Order();
    }
}
