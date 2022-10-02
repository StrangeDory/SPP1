using System;
using System.Diagnostics;
using System.Reflection;

namespace TracerLib
{
    [Serializable]
    public class Tracer : ITracer
    {
        private ThreadResult TraceResult;

        public Tracer()
        {
            TraceResult = new ThreadResult();
        }

        public void StartTrace()
        {
            StackFrame frame = new StackFrame(1);
            MethodBase method = frame.GetMethod();
            var traceResult = GetTraceResult();
            traceResult.StartMethodTrace(method);
        }

        public void StopTrace()
        {
            TraceResult.StopMethodTrace();
        }

        public ThreadResult GetTraceResult()
        {
            return TraceResult;
        }
    }
}
