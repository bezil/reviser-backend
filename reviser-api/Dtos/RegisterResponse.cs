using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reviser_api.Dtos
{
    public class RegisterResponse
    {
        public string Message { get; set; } = string.Empty;
        public bool Success { get; set; }
    }
}
