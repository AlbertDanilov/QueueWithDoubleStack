using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueWithDoubleStack
{
    public class Queue<T> {
        private Stack<T> stack_pop = new Stack<T>();
        private Stack<T> stack_push = new Stack<T>();

        public void addToQueue(T element) {
            stack_push.Push(element);
        }

        public T getFromQueue()
        {
            if (stack_pop.Count == 0) { 
                while (stack_push.Count > 0) {
                    stack_pop.Push(stack_push.Pop());
                }
            }

            if (stack_pop.Count == 0)
            {
                return default(T);
            }

            return stack_pop.Pop();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            numbers.addToQueue(1);
            numbers.addToQueue(2);
            numbers.addToQueue(3);

            numbers.getFromQueue();

            numbers.addToQueue(4);
            numbers.addToQueue(5);

            numbers.getFromQueue();
            numbers.getFromQueue();
            numbers.getFromQueue();
            numbers.getFromQueue();
            numbers.getFromQueue();
            numbers.getFromQueue();
        }
    }
}
