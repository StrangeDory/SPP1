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

            tester.TestMethod();
            tester.TestTestTset();

            var testThread = new Thread(() =>
            {
                tester.TestTestTset();
            });
            testThread.Start();
            testThread.Join();

            JsonCustomSerializer serializerJSON = new JsonCustomSerializer();
            XmlCustomSerializer serializerXML = new XmlCustomSerializer();
            OutputFile outputResultToFile = new OutputFile();
            outputResultToConsole.OutputResult(serializerJSON.Serialize(tracer));
            outputResultToConsole.OutputResult(serializerXML.Serialize(tracer));
            outputResultToFile.SavePath = "E:\\СПП\\SPP-master\\Files\\JSON.json";
            outputResultToFile.OutputResult(serializerJSON.Serialize(tracer));
            outputResultToFile.SavePath = "E:\\СПП\\SPP-master\\Files\\XML.xml";
            outputResultToFile.OutputResult(serializerXML.Serialize(tracer));
        }
    }
}
