using System.Collections.Generic;

namespace _3._2._3.Using_Hashing
{
    // A Native set Implementation
    public class MainListing3X21<T>
    {
        private List<T> list = new List<T>();
        
        public void Insert(T item)
        {
            if(!Contains(item))
                    list.Add(item);
        }

        public bool Contains(T item)
        {
            foreach (T member in list)
                if(member.Equals(item))
                    return true;

            return false;    
        }

        
    }

}