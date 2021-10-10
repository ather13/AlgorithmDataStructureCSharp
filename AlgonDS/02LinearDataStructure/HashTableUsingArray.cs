/*
 *  Hashtable is a data structure which maintain the value based on Key Value pair. 
 */

using System;

namespace AlgonDS._02LinearDataStructure
{

    /// <summary>
    /// Hash table implementation
    /// </summary>
    public class HashTableUsingArray
    {
        private readonly HashTableNode[] _hashTableNodes;
        private readonly int _maxSize;

        public HashTableUsingArray(int maxSize)
        {
            _maxSize = maxSize;
            _hashTableNodes = new HashTableNode[maxSize];
        }

        public object this[string key]
        {
            get =>  Get(key);
            set => Set(key,value);
        }

        /// <summary>
        /// Function to generate hash
        /// Note : This hash function is not very strong to use in production
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private uint SdbmHash(string key)
        {
            uint hash = 0;
            foreach (var k in key)
            {
                hash = hash * 65599 + (uint)k;
            }

            return (uint)(hash % _maxSize);
        }
        
        /// <summary>
        /// Generate index for the key (using hash function) and save to hash table array
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        private void Set(string key, object value)
        {
            var index = SdbmHash(key);
            var node = _hashTableNodes[index];

            if (node == null)
            {
                _hashTableNodes[index] = new HashTableNode(key, value);
                return;
            }

            if (node.Key == key)
                throw new Exception($"Key {key} already exists!");

            while (node.Next != null)
            {
                node = node.Next;
                if (node.Key == key)
                    throw new Exception($"Key {key} already exists!");
            }

            node.Next = new HashTableNode(key, value, node);
        }

        /// <summary>
        /// Generate index from the key (using hash function) and retrieve value from hash table array based on the index
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private object Get(string key)
        {
            var genIndex = SdbmHash(key);
            var node = _hashTableNodes[genIndex];

            while (node != null)
            {
                if (node.Key == key)
                {
                    return node.Value;
                }
                node = node.Next;
            }

            throw new Exception($"Value for the key {key} does not exists!");
        }
    }

    /// <summary>
    /// Node for hash table
    /// </summary>
    public class HashTableNode
    {
        public string Key { get; set; }
        public object Value { get; set; }
        public HashTableNode Next { get; set; }
        public HashTableNode Previous { get; set; }

        public HashTableNode(string key, object value)
        {
            this.Key = key;
            this.Value = value;
        }

        public HashTableNode(string key, object value, HashTableNode previous) : this(key,value)
        {
            this.Previous = previous;
        }
    }
}
    
