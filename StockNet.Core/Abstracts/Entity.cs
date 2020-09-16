using StockNet.Core.Interfaces;

namespace StockNet.Core.Abstracts
{
    public class Entity : IEntity
    {
        private int _id;
        public int Id {
            get => _id;
            set => _id = value;   
        }
    }
}
