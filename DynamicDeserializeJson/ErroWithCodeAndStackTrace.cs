using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DynamicDeserializeJson
{
    [JsonSerializable(typeof(ErroWithCodeAndStackTrace))]
    public class ErroWithCodeAndStackTrace : ExceptionDtoWithStackTrace
    {

        public int Code { get; set; }

        public ErroWithCodeAndStackTrace(Exception ex) : base(ex)
        {

        }
    }
}