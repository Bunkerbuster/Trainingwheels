using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander_Core_3._1_MVC_Rest_Api.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }

        // Removing for illustration 
        //public string Platform { get; set; }
    }
}
