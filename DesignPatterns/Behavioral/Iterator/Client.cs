using System.Reactive.Linq;

namespace DesignPatterns.Behavioral.Iterator
{
    internal class Client
    {
        public static void Execute()
        {
           /* List<string> list = new List<string>() { "1", "2", "3", "4", "5", "6" };


            var temp = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                Console.WriteLine(temp + list[i]);
                temp = list[i];
            }*/

            Console.WriteLine("--");

            IEnumerable<string> list = new List<string>() { "1", "2", "3", "4", "5", "6" };

            var iterator = list.GetEnumerator();
            if (iterator.MoveNext())
            {
                var temp = iterator.Current;
                while (iterator.MoveNext())
                {
                    Console.WriteLine(temp + iterator.Current);
                    temp = iterator.Current;
                }
            }

            Console.WriteLine("--");

            var bufferIterator = new BufferIterator<string>(list);
            while (bufferIterator.MoveNext())
            {
                Console.WriteLine(bufferIterator.Current.Item1 + bufferIterator.Current.Item2);
            }

            Console.WriteLine("--");

            foreach (var item in new BufferCollection<string>(list))
            {
                Console.WriteLine(item.Item1 + item.Item2);
            }

            Console.WriteLine("--");

            list.ToObservable()
                .Buffer(2, 1)
                .Where(x => x.Count == 2)
                .Subscribe(x => Console.WriteLine(x[0] + x[1]));
        }
    }
}
