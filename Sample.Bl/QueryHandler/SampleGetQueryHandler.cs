using System.Collections.Generic;
using System.Linq;
using Sample.Bl.Query;
using Sample.Bl.QueryResult;
using Sample.Core;
using Sample.Model.EF.Context;
using Sample.Model.EF.Context.Base;

namespace Sample.Bl.QueryHandler
{
    public class SampleGetQueryHandler : BaseContext<UserContext>,  IQueryHandler<SampleGetQuery,SampleGetQueryResult>
    {


 
        public SampleGetQueryHandler(UserContext context) : base(context) 
        {
            
        }

        public SampleGetQueryResult Retrieve(SampleGetQuery query)
        {

            return new SampleGetQueryResult
            {
                Users = _db.Users.Select(x => x).ToList()
            };
        }
    }
}