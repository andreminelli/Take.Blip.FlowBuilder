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
                                .WhenReceived(MatchTextRegEx("3|Voltar"), SetHandler<BackHandler>());
            var mainFlow = FlowBuilder.Start()
                            .WhenReceived(MatchTextRegEx("123.456.789-00"), Send(""), Start(optionsFlow))
                            .WhenReceived(MatchTextRegEx("\\d[11]"), Send(""))
                            .Otherwise(Send("Não entendi o que você quis dizer...", "O que? Tente novamente, por favor"));
        }

        private IFlowBuilder Start(IFlowBuilder flow)
        {
            return flow;
        }

        private IOutputResponse Send(params string[] v)
        {
            return new SendOutputResponse(v);
        }

        private IOutputResponse SetHandler<T>()
        {
            return new SetHandler<T>();
        }

        private IInputFilter MatchTextRegEx(string v)
        {
            return new MatchTextRegExInputFilter(v);
        }
    }
}
