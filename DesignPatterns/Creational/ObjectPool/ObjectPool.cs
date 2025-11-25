using System.Collections.Concurrent;

namespace DesignPatterns.Creational.ObjectPool
{
    internal class ObjectPool<T>
    {
        private ConcurrentQueue<T> _queue;
        public ObjectPool(int count, Func<T> create)
        {
            _queue = new ConcurrentQueue<T>(Enumerable.Range(1, count).Select(x => create()));
        }

        public T? Acquire()
        {
            if (_queue.TryDequeue(out var result))
            {
                return result;
            }
            return default;
        }

        public void Release(T item)
        {
            _queue.Enqueue(item);
        }
    }
}
