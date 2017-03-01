using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Take.Blip.FlowBuilder
{
    class Sample
    {
        public void Build()
        {
            var optionsFlow = FlowBuilder.Start()
                                .WhenReceived(MatchTextRegEx("1|Extrato"), SetHandler<NoteHandler>())
                                .WhenReceived(MatchTextRegEx("2|Saldo"), SetHandler<AmountHandler>())
                                .WhenReceived(MatchTextRegEx("3|Voltar"), SetHandler<AmountHandler>());
            var mainFlow = FlowBuilder.Start()
                            .WhenReceived(MatchTextRegEx(""), Send(""))
                            .WhenReceived(MatchTextRegEx(""), Send(""), Start(optionsFlow))
                            .Otherwise(Send(""));
        }
    }
}
