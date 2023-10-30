using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1.Engine.Render
{
    public class RenderHost : IRenderHost
    {
        public IntPtr HostHandle {  get; private set; }

        public RenderHost(IntPtr hostHandle)
        {
            HostHandle = hostHandle;
        }

        public void Dispose()
        {
            HostHandle = default;
        }

    }
}
