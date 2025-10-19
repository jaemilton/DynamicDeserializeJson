using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DynamicDeserializeJson
{
    [JsonSerializable(typeof(ErroWithInnerExceptionOnly))]
    public class ErroWithInnerExceptionOnly : ExceptionDtoWithInnerException
    {

        public ErroWithInnerExceptionOnly(Exception ex) : base(ex)
        {
        }

    }
}