using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson;

namespace reviser_api.Models
{
    public class Threads
    {
        public ObjectId Id { get; set; }
        public string? Name { get; set;}
    }
}
