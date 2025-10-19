using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DynamicDeserializeJson
{
    public class ObjModelProducerBase
    {
        [JsonSerializable(typeof(ObjModelReceiver))]
        public class ObjModelReceiver
        {
            public required string StringNonNullable { get; set; }
            public required int IntNonNullable { get; set; }

            public string? StringNullable { get; set; }
            public int? IntNullable { get; set; }

        }
    }
}
