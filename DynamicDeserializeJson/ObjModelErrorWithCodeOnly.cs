using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DynamicDeserializeJson
{
    [JsonSerializable(typeof(ObjModelErrorWithCodeOnly))]
    public class ObjModelErrorWithCodeOnly
    {
        public required string StringNonNullable { get; set; }
        public required int IntNonNullable { get; set; }

        public string? StringNullable { get; set; }
        public int? IntNullable { get; set; }

        public ErrorWithCodeOnly? Json { get; set; }
    }
}
