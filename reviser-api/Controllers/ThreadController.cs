using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using MongoDB.Driver;

using reviser_api.Models;

namespace reviser_api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/threads")]
    public class ThreadController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ThreadController(IConfiguration configuration){
            _configuration = configuration;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Threads>> Get(){
            MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("MongoDb"));

            var threads = dbClient.GetDatabase("ReviserDatabase").GetCollection<Threads>("ThreadCollection").AsQueryable();

            return Ok(threads);
        }

        [HttpPost]
        [Route("/create-thread")]
        public ActionResult<Threads> Post(Threads thread){
            MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("MongoDb"));

            dbClient.GetDatabase("ReviserDatabase").GetCollection<Threads>("ThreadCollection").InsertOne(thread);

            return Ok("Thread added successfully");
        }
    }
}
