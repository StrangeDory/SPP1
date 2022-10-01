using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TracerLib
{
    public class XmlCustomSerializer : ISerializer
    {
        public string Serialize(ITracer tracer)
        {
            MemoryStream memoryStream = new MemoryStream();

            var xmlSerializer = new XmlSerializer(typeof(Tracer));

            xmlSerializer.Serialize(memoryStream, tracer);
            memoryStream.Position = 0;

            StreamReader sr = new StreamReader(memoryStream);
            return sr.ReadToEnd();
        }
    }
}
