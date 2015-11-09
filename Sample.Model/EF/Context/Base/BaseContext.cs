using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Sample.Model.EF.Context.Base
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {
        protected TContext _db;
        public BaseContext(TContext context) : base("DefaultConnection")
        {
            _db = context;
            Database.SetInitializer<TContext>(null);   
        }
        public virtual ObjectContext ToObjectContext()
        {
            return ((IObjectContextAdapter)this).ObjectContext;
        }
    }
}