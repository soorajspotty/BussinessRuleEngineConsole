using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleProcessor
{
    /// <summary>
    /// Common interface to be implemented all Payment Services
    /// This will be used refer payment service types when needed.
    /// </summary>
    public interface IPaymentService
    {
        string ProcessPaymenRequest();
    }

}
