using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DynamicDeserializeJson
{
    [JsonSerializable(typeof(ExceptionDtoBase))]
    public class ExceptionDtoBase
    {
        public string Message { get; set; }
        public string ExceptionType { get; set; }
        public ExceptionDtoBase(Exception ex)
        {
            Message = ex.Message;
            ExceptionType = ex.GetType().FullName!;
        }
    }
}
