using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DynamicDeserializeJson
{
    [JsonSerializable(typeof(ErrorWithCodeOnly))]
    public class ErrorWithCodeOnly : ExceptionDtoBase
    {

        public int Code { get; set; }

        public ErrorWithCodeOnly(Exception ex) : base(ex)
        {

        }
    }
}