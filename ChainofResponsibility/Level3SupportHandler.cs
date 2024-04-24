using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    public class Level3SupportHandler : ISupportHandler
    {
        private ISupportHandler _handler;
        public void handleReques(Request request)
        {
            if (request.priority == Priority.CRITICAL)
            {
                Console.WriteLine("Level 3 support handled the request");
            }
        }

        public void SetNextHandler(ISupportHandler handler)
        {
            this._handler = handler;
        }
    }
}
