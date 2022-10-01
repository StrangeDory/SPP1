using System.IO;

namespace spp_lab1
{
    class OutputFile
    {
        public string SavePath { get; set; }
        public void OutputResult(string result)
        {
            using (StreamWriter sw = new StreamWriter(SavePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(result);
            }
        }
        public OutputFile()
        {
            SavePath = "test.json";
        }
    }
}
