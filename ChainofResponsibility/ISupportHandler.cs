using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    public interface ISupportHandler
    {
        void handleReques(Request request);
        void SetNextHandler(ISupportHandler handler);
    }
}
