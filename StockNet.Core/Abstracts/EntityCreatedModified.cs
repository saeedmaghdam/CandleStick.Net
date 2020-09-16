using System;

namespace StockNet.Core.Abstracts
{
    public class EntityCreatedModified : EntityCreated
    {
        protected DateTime _modifiedDate;
        
        public DateTime ModifiedDate => _modifiedDate; 
    }
}
