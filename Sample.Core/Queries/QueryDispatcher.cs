﻿using System;
using Ninject;

namespace Sample.Core
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IKernel _kernel;

        public QueryDispatcher(IKernel kernel)
        {
            if (kernel == null)
            {
                throw new ArgumentNullException("kernel");
            }
            _kernel = kernel;
        }
        public TResult Dispatch<TParameter, TResult>(TParameter query) where TParameter : IQuery where TResult : IQueryResult
        {
            var handler = _kernel.Get<IQueryHandler<TParameter, TResult>>();
            return handler.Retrieve(query);
        }
    }
}