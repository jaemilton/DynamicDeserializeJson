using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DynamicDeserializeJson
{
    [JsonSerializable(typeof(ExceptionDtoWithInnerException))]
    public class ExceptionDtoWithInnerException : ExceptionDtoBase
    {
        public ExceptionDtoWithInnerException(Exception ex): base(ex)
        {
            if (ex.InnerException != null)
            {
                InnerException = new ExceptionDtoWithInnerException(ex.InnerException);
            }
        }
        public ExceptionDtoWithInnerException? InnerException { get; set; }
    }
}
