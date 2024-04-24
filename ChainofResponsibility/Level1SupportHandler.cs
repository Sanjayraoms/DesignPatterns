using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    public class Level1SupportHandler : ISupportHandler
    {
        private ISupportHandler _nextHandler;

        public void handleReques(Request request)
        {
            if (request.priority == Priority.BASIC)
            {
                Console.WriteLine("Level 1 support handled the request");
            }
            else
            {
                this._nextHandler.handleReques(request);
            }
        }

        public void SetNextHandler(ISupportHandler handler)
        {
            this._nextHandler = handler;
        }
    }
}
