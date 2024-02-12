class MyHashMap:
    def __init__(self):
        self.capacity = 11
        self.buckets = [Bucket() for _ in range(self.capacity)]

    def hash_function(self, key):
        return abs(key) % self.capacity

    def put(self, key, value):
        hash = self.hash_function(key)
        bucket = self.buckets[hash]
        key_found = False
        for tab in bucket.data:
            if tab[0] == key:
                tab[1] = value
                key_found = True
                break
        if not key_found:
            bucket.data.append([key, value])

    def get(self, key):
        hash = self.hash_function(key)
        bucket = self.buckets[hash]
        for tab in bucket.data:
            if tab[0] == key:
                return tab[1]
        return -1

    def remove(self, key):
        hash = self.hash_function(key)
        bucket = self.buckets[hash]
        for i, pair in enumerate(bucket.data):
            if pair[0] == key:
                del bucket.data[i]
                break

class Bucket:
    def __init__(self):
        self.data = []


# Your MyHashMap object will be instantiated and called as such:
# obj = MyHashMap()
# obj.put(key,value)
# param_2 = obj.get(key)
# obj.remove(key)