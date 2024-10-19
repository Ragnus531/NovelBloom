using System;
using System.Collections.Generic;

namespace NovelBloom.CustomTypes;

public class AutoRemoveDictionary<TKey, TValue>
{
    private readonly Dictionary<TKey, TValue> _dictionary = new();

    // Indexer to access and remove the item
    public TValue this[TKey key]
    {
        get
        {
            if (_dictionary.TryGetValue(key, out TValue value))
            {
                _dictionary.Remove(key); // Remove the item once accessed
                return value;
            }
            else
            {
                throw new KeyNotFoundException($"The key '{key}' was not found.");
            }
        }
        set { _dictionary[key] = value; }
    }

    public void Add(TKey key, TValue value)
    {
        _dictionary.Add(key, value);
    }

    public bool ContainsKey(TKey key)
    {
        return _dictionary.ContainsKey(key);
    }

    public int Count => _dictionary.Count;

    public void Clear()
    {
        _dictionary.Clear();
    }

    public bool Remove(TKey key)
    {
        return _dictionary.Remove(key);
    }
}
