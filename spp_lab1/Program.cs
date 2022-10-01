using System;
using System.Threading;
using TracerLib;

namespace spp_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tracer tracer = new Tracer();
            OutputConsole outputResultToConsole = new OutputConsole();
            TracerTest tester = new TracerTest(tracer);

            tester.TestMethod1();
            tester.TestMethod2();
            tester.TestMethod3();

            JsonCustomSerializer serializerJSON = new JsonCustomSerializer();
            XmlCustomSerializer serializerXML = new XmlCustomSerializer();
            OutputFile outputResultToFile = new OutputFile();
            outputResultToConsole.OutputResult(serializerJSON.Serialize(tracer));
            outputResultToConsole.OutputResult(serializerXML.Serialize(tracer));
            outputResultToFile.SavePath = "E:\\СПП\\spp_lab1\\Results\\JSON.json";
            outputResultToFile.OutputResult(serializerJSON.Serialize(tracer));
            outputResultToFile.SavePath = "E:\\СПП\\spp_lab1\\Results\\XML.xml";
            outputResultToFile.OutputResult(serializerXML.Serialize(tracer));
        }
    }
}
