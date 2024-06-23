using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Domain.DTOs
{
    public class ResponseDTO
    {
        public Dictionary<string, string> response { get; set; } = new Dictionary<string, string>(); 
    }
}
