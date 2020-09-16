using System;

namespace StockNet.Core.Abstracts
{
    public class EntityCreatedModifiedDeleted : EntityCreatedModified
    {
        protected DateTime _deletedDate;
        
        public DateTime DeletedDate => _deletedDate;
    }
}
