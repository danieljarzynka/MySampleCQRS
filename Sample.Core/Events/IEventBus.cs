namespace Sample.Core
{
    public interface IEventBus
    {
        void PublishEvents<T>(T cmd) where T : IEvent;

    }
}