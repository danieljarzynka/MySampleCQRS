using Ninject;

namespace Sample.Core
{
    public interface ICommandHandler<in TParameter> where TParameter :ICommand
    {
        void Execute(TParameter command,IKernel kernel);
    }
}