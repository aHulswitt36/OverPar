using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverPar.Domain.Interfaces.Connectors
{
    public interface IFormRecognizorConnector
    {
        Task ProcessScorecardAsync(byte[] imageBytes, CancellationToken token);
    }
}
