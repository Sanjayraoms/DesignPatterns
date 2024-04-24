using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    public class Level2Handler : ISupportHandler
    {
        private ISupportHandler _nexthandler;
        public void handleReques(Request request)
        {
            if (request.priority == Priority.INTERMEDIATE)
            {
                Console.WriteLine("Level 2 support handled the request ");
            }
            else
            {
                this._nexthandler.handleReques(request);
            }
        }

        public void SetNextHandler(ISupportHandler handler)
        {
            this._nexthandler = handler;
        }
    }
}
