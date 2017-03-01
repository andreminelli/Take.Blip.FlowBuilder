namespace Take.Blip.FlowBuilder
{
    internal interface IFlowBuilder
    {
        IFlowBuilder WhenReceived(IInputFilter filter, IOutputResponse response, IFlowBuilder flow = null);
        IFlowBuilder Otherwise(IOutputResponse outputResponse);
    }
}