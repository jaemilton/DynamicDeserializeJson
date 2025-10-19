using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDeserializeJson
{
    public class CustomErrorClass
    {
        public required string Name { get; set; }
        public List<string>? Details { get; set; }
    }
}
