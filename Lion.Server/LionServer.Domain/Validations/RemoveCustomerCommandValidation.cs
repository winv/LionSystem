using LionServer.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace LionServer.Domain.Validations
{
    public class RemoveCustomerCommandValidation : CustomerValidation<RemoveCustomerCommand>
    {
        public RemoveCustomerCommandValidation()
        {
            ValidateId();
        }
    }
}
