public class MyHashMap
{
    private int capacity;
    private List<Bucket> buckets;

    public MyHashMap()
    {
        capacity = 11;
        buckets = new List<Bucket>(capacity);
        for (int i = 0; i < capacity; i++) 
        {
            buckets.Add(new Bucket());
        }
    }

    private int HashFunction(int key)
    {
        return Math.Abs(key) % capacity;
    }

    public void Put(int key, int value)
    {
        int hash = HashFunction(key);
        Bucket bucket = buckets[hash];
        bool keyFound = false;
        foreach (var tab in bucket.Data)
        {
            if (tab[0] == key)
            {
                tab[1] = value;
                keyFound = true;
                break;
            }
        }
        if (!keyFound)
        {
            bucket.Data.Add(new int[] { key, value });
        }
    }

    public int Get(int key)
    {
        int hash = HashFunction(key);
        Bucket bucket = buckets[hash];
        foreach (var tab in bucket.Data)
        {
            if (tab[0] == key)
            {
                return tab[1];
            }
        }
        return -1;
    }

    public void Remove(int key)
    {
        int hash = HashFunction(key);
        Bucket bucket = buckets[hash];
        int index = -1;
        bool keyFound = false;
        for (int i = 0; i < bucket.Data.Count; i++)
        {
            if (bucket.Data[i][0] == key)
            {
                index = i;
                keyFound = true;
                break;
            }
        }
        if (keyFound)
        {
            bucket.Data.RemoveAt(index);
        }
    }
}

public class Bucket
{
    public List<int[]> Data { get; }

    public Bucket()
    {
        Data = new List<int[]>();
    }
}


/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */