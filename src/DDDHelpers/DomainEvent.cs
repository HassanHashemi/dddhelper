using System;
using News.Domain;

namespace Domain
{
    public abstract class DomainEvent : Event
    {
        protected DomainEvent()
        {
        }

        protected DomainEvent(Guid aggregateRootId)
        {
            Guard.NotNullOrDefault(aggregateRootId, nameof(aggregateRootId));

            this.AggregateRootId = aggregateRootId;
        }

        public Guid AggregateRootId { get; private set; }
    }
}
