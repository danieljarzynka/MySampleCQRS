using System.Data.Entity;
using Sample.Model.EF.Model;

namespace Sample.Model.EF.Context
{
    public class UserContext  :DbContext
    {
        public UserContext()
            : base("DefaultConnection")
        {
            
        }
        public virtual IDbSet<User> Users { get; set; }
    }
}