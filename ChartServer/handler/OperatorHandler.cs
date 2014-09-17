using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChartServer.model;

namespace ChartServer.handler
{
    public interface OperatorHandler
    {
        void execute(TransferProtocol tp);

    }
}
