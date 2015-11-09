using System;
using System.Collections.Generic;
using System.Linq;
using Ninject;

namespace Sample.Core
{
    public class EventsBus : IEventBus
    {
//      
        private IKernel _kernel;
        public EventsBus(IKernel kernel)
        {
            if (kernel == null)
            {
                throw new ArgumentNullException("kernel");
            }
            _kernel = kernel;
        }
//        private readonly Func<Type, IEnumerable<IHandleEvent>> _handlersFactory;
//        public EventsBus(Func<Type, IEnumerable<IHandleEvent>> handlersFactory)
//        {
//            _handlersFactory = handlersFactory;
//        }
        public void PublishEvents<T>(T e) where T : IEvent
        {

            var handlers = _kernel.GetAll<IHandleEvent<T>>();
//
            foreach (var handler in handlers)
            {
             handler.Handle(e);
             
//                handler.Handle(e);
            }
        }
    }
}