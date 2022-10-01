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
    }
}
