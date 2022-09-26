using System.Collections.Generic;

namespace TracerLib
{
    interface ISerializer
    {
        string Serialize(List<ThreadResult> value);
    }
}
