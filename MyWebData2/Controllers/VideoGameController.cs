using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace MyWebData2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoGameController : ControllerBase
    {
        public static Items.TempGames data = new Items.TempGames();


        
        public VideoGameController()
        {
            Console.WriteLine("Spinning up VideogameController");
        }

        [HttpGet]
        [Route("get")]
        public String Get()
        {
            var json = JsonConvert.SerializeObject(data.MyList);

            return json;

        }

    }
}
