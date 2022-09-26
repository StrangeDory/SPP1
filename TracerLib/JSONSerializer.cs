using Newtonsoft.Json;
using System.Collections.Generic;

namespace TracerLib
{
    public class JsonCustomSerializer : ISerializer
    {
        public string Serialize(List<ThreadResult> value)
        {
            return JsonConvert.SerializeObject(value, Formatting.Indented);
        }
    }
}
