using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleProcessor.AgentCommission
{
    interface IAgentCommision
    {
        bool GenerateAgentCommision(double percentage);
    }
}
