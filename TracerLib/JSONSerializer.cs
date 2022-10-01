using Newtonsoft.Json;
using System.Collections.Generic;

namespace TracerLib
{
    public class JsonCustomSerializer : ISerializer
    {
        public string Serialize(ITracer tracer)
        {
            return JsonConvert.SerializeObject(tracer.GetTraceResult(), Formatting.Indented);
        }
    }
}
