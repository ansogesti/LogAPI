using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogAPI.Data;
using LogAPI.Models;
using LogAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ApiServices ApiService;

        public LogController(Context db)
        {
            ApiService = new ApiServices(db);
        }

        // PUT: api/Log/json
        [HttpPut("{json}")]
        public async void Put([FromBody] string json)
        {
            LogModel log = JsonConvert.DeserializeObject<LogModel>(json);
            await ApiService.PutLog(log);
        }

    }
}
