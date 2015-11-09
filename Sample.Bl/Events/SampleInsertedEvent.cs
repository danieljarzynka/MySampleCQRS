using Sample.Core;

namespace Sample.Bl.Events
{
    public class SampleInsertedEvent : IEvent
    {
        public int SampleInsertedId { get; set; }
    }

    public class WhenSampleInsertedEvendSucces : IHandleEvent<SampleInsertedEvent>
    {
        public void Handle(SampleInsertedEvent @event)
        {
            
        }
    } 
    public class WhenSampleInsertedEvendSuccesTestNextHandler : IHandleEvent<SampleInsertedEvent>
    {
        public void Handle(SampleInsertedEvent @event)
        {
            
        }
    }
}