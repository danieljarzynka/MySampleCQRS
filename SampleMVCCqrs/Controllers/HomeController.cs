using System.Collections.Generic;
using System.Web.Mvc;
using Sample.Bl.Commnad;
using Sample.Bl.Query;
using Sample.Bl.QueryResult;
using Sample.Core;

namespace SampleMVCCqrs.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly ICommandDispatcher _commandDispatcher;
        public HomeController(IQueryDispatcher queryDispatcher,ICommandDispatcher commandDispatcher)
        {
            _queryDispatcher = queryDispatcher;
            _commandDispatcher = commandDispatcher;
        }
        public ActionResult Index()
        {
            var query = new SampleGetQuery {SampleBool = false};
            //should add user with username - userNameForInsert and execute sample events
            _commandDispatcher.Dispatch(new SampleInsertCommand {SampleName = "userNameForInsert"});
            //should get all users (for debugging test)
            var result = _queryDispatcher.Dispatch<SampleGetQuery, SampleGetQueryResult>(query);
            return View();
        }
    }
}