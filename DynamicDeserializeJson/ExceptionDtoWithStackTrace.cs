using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDeserializeJson
{
    public class ExceptionDtoWithStackTrace : ExceptionDtoBase
    {
        public string? StackTrace  { get; set; }
        public ExceptionDtoWithStackTrace(Exception ex): base(ex)
        {
            StackTrace = ex.StackTrace;
        }
    }
}
