using System;

namespace StockNet.Core.Abstracts
{
    public class EntityCreated : Entity
    {
        protected DateTime _createdDate;

        public DateTime CreatedDate => _createdDate;
    }
}
