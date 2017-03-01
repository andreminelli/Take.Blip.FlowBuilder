namespace Take.Blip.FlowBuilder
{
    internal class SendOutputResponse : IOutputResponse
    {
        private string[] v;

        public SendOutputResponse(params string[] v)
        {
            this.v = v;
        }
    }
}