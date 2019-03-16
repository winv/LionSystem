using LionServer.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace LionServer.Domain.Events
{
    public class CustomerRemovedEvent : Event
    {
        public CustomerRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}
