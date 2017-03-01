using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take.Blip.FlowBuilder
{
    class FlowBuilder : IFlowBuilder
    {
        internal static IFlowBuilder Start()
        {
            return new FlowBuilder();
        }

        public IFlowBuilder WhenReceived(IInputFilter filter, IOutputResponse response, IFlowBuilder flow = null)
        {
            return this;
        }

        public IFlowBuilder Otherwise(IOutputResponse outputResponse)
        {
            return this;
        }
    }
}
