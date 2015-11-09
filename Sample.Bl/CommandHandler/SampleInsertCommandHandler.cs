using Ninject;
using Sample.Bl.Commnad;
using Sample.Bl.Events;
using Sample.Core;
using Sample.Model.EF.Context;
using Sample.Model.EF.Context.Base;
using Sample.Model.EF.Model;

namespace Sample.Bl.CommandHandler
{
    public class SampleInsertCommandHandler : BaseContext<UserContext>, ICommandHandler<SampleInsertCommand>
    {
        private IEventBus _eventsBus;
        public SampleInsertCommandHandler(UserContext context)
            : base(context)
        {
        }
       
        public void Execute(SampleInsertCommand command, IKernel kernel)
        {
            _db.Users.Add(new User {UserName = command.SampleName});
            _db.SaveChanges();

             _eventsBus = new EventsBus(kernel);
            _eventsBus.PublishEvents(new SampleInsertedEvent
            {
                SampleInsertedId = 123
            });
        }

       
    }
}