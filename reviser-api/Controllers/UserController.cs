using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using reviser_api.Models;

namespace reviser_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public UserController(IConfiguration configuration){
            _configuration = configuration;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get(){
            MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("MongoDb"));

            var userList = dbClient.GetDatabase("ReviserDatabase").GetCollection<User>("UserCollection").AsQueryable();

            return Ok(userList);
        }
    }
}
