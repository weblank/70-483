using System.Collections.Generic;

namespace _3._2._3.Using_Hashing
{
    // A Set Implementation that uses Hashing
    public class MainListing3X22<T>
    {
        private List<T>[] buckets = new List<T>[100];
        
        public MainListing3X22()
        {

        }

        public void Insert(T item)
        {
            int bucket = GetBucket(item.GetHashCode());
            if(Contains(item,bucket))
                    return;

            if(buckets[bucket] == null)
                buckets[bucket] = new List<T>();
            buckets[bucket].Add(item);
        }


        public bool Contains(T item)
        {
            return Contains(item,GetBucket(item.GetHashCode()));    
        }

        private int GetBucket(int hashcode)
        {
            // A Hash code can be negative. To make sure that you end up with a positive
            // value cast the value to an unsigned int. The unchecked block makes sure that
            // you can cast a value larger then int to an int safely.
            unchecked
            {
                return (int)((uint)hashcode % (uint)buckets.Length);
            }
        }

        private bool Contains(T item, int bucket)
        {
            if(buckets[bucket] != null)
                foreach (T member in buckets[bucket])
                    if(member.Equals(item))
                        return true;
            
            return false;

        }
        
    }

}