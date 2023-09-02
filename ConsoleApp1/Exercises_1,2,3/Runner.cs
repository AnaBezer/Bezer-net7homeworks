using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericExercises
{
    public static class Runner
    {
        public static void ReverseList<T>(List<T> elements)
        {
            elements.Reverse();
        }

        public static List<T> SortList<T>(List<T> names)
        {
            return names.OrderBy(name => name).ToList();
        }

    }
}

public class QueueRunner<T>
{
    private Queue<T> queue;
    public QueueRunner()
    {
        queue = new Queue<T>();
    }

    public void Enqueue(T item)
    {
        queue.Enqueue(item);
    }

    public T Dequeue()
    {
        if (queue.Count == 0)
        {
            throw new Exception("The queue is empty");
        }
        return queue.Dequeue();
    }

    public T Peek(T item)
    {
        if (queue.Count == 0)
        {
            throw new Exception("The queue is empty");
        }
        return queue.Peek();
    }

    public int Count
    {
        get { return queue.Count; }
    }
}

public static class InterfaceRunner
{
    public interface IComparer<T>
    {
        int Compare(T item1, T item2);
    }
    public class StringLengthComparer : IComparer<string>
    {
        public int Compare(string str1, string str2)
        {
            return str1.Length.CompareTo(str2.Length);
        }
    }
    public class CollectionSizeComparer<T> : IComparer<ICollection<T>>
    {
        public int Compare(ICollection<T> collection1, ICollection<T> collection2)
        {

            return collection1.Count.CompareTo(collection2.Count);
        }

    }

}