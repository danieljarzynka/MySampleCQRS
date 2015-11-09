using Ninject;

namespace Sample.Core
{
    public interface IQueryHandler<in TParameter, out TResult> where TParameter : IQuery
    {
        TResult Retrieve(TParameter query);
    }
}