using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take.Blip.FlowBuilder
{
    class MatchTextRegExInputFilter : IInputFilter
    {
        private string v;

        public MatchTextRegExInputFilter(string v)
        {
            this.v = v;
        }
    }
}
