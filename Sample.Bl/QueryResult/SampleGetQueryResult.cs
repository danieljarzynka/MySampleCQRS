using System.Collections;
using System.Collections.Generic;
using Sample.Core;
using Sample.Model.EF.Model;

namespace Sample.Bl.QueryResult
{
    public class SampleGetQueryResult : IQueryResult
    {
        public IList<User> Users { get; set; }
        
    }
}