using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.COR
{
    internal class Pipeline
    {
        List<Middleware> middlewares;

        public Pipeline()
        {
            middlewares = new List<Middleware>();
        }
        internal void Use(Middleware middleware)
        {
            if (middlewares.Count == 0)
            {
                middlewares.Add(middleware);
                return;
            }

            var lastMiddleware = middlewares.Last();
            lastMiddleware.SetNextHandler(middleware);
            middlewares.Add(middleware);
        }

        internal void Execute()
        {
            var request = new HttpRequest();
            if(middlewares.Count > 0)
            {
                _handle(request, middlewares.First().Handle(request));
            }
        }

        private void _handle(IRequest request, IMiddleware response)
        {
            if(response is NoopMiddleware)
            {
                Console.WriteLine("No next Middleware found to execute");
            }
            else
            {
                _handle(request, response.Handle(request));
            }

        }
    }
}
