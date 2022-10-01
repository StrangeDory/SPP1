using System.Threading;
using TracerLib;

namespace spp_lab1
{
    class Example
    {
        public ITracer tracer;

        public Example(ITracer tracer)
        {
            this.tracer = tracer;
        }

        public void MethodFirst()
        {
            tracer.StartTrace();
            Thread.Sleep(500);
            tracer.StopTrace();
        }

        public void MethodSecond()
        {
            tracer.StartTrace();
            Thread.Sleep(100);
            MethodFirst();
            tracer.StopTrace();
        }

        public void MethodThird()
        {
            tracer.StartTrace();
            MethodFirst();
            MethodSecond();
            tracer.StopTrace();
        }
    }
}
