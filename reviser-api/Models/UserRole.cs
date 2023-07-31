using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace reviser_api.Models
{
    [CollectionName("RolesCollection")]
    public class UserRole : MongoIdentityRole<Guid>
    {
        public string FullName { get; set; } = string.Empty;
    }
}
