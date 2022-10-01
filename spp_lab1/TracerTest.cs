using System.Threading;
using TracerLib;

namespace spp_lab1
{
    class TracerTest
    {
        private ITracer _tracer;
        internal TracerTest(ITracer tracer)
        {
            _tracer = tracer;
        }

        public void TestMethod1()
        {
            _tracer.StartTrace();
            Example test = new Example(_tracer);
            var testThread = new Thread(() =>
            {
                test.MethodFirst();
            });
            testThread.Start();
            testThread.Join();
            Thread.Sleep(100);
            _tracer.StopTrace();
        }

        public void TestMethod2()
        {
            _tracer.StartTrace();
            Example test = new Example(_tracer);
            var testThread = new Thread(() =>
            {
                test.MethodSecond();
            });
            testThread.Start();
            testThread.Join();
            Thread.Sleep(200);
            _tracer.StopTrace();
        }

        public void TestMethod3()
        {
            _tracer.StartTrace();
            Example test = new Example(_tracer);
            var testThread = new Thread(() =>
            {
                test.MethodThird();
            });
            testThread.Start();
            testThread.Join();
            Thread.Sleep(300);
            _tracer.StopTrace();
        }
    }
}
