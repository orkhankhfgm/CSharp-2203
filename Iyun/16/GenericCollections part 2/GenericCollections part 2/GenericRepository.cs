using System.Collections.Generic;

namespace GenericCollections_part_2
{
    public class GenericRepository<T> where T : class
    {
        public virtual List<T> Get()
        {
            return null;
        }

        public virtual void Add(T data)
        {

        }
    }
}
