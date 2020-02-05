using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
    
            var queue = new Queue<long>();

     
            queue.Enqueue(380991234567);//3
            queue.Enqueue(380919485718);//2
            queue.Enqueue(380445105858);//1
            
            Console.WriteLine(queue.Count);
            var item1 = queue.Dequeue();
            Console.WriteLine(item1);//1

            queue.Enqueue(72410242185);//new 3

            var item4 = queue.Peek();
            Console.WriteLine(item4);
           
            

            Console.ReadLine();
        }
    }
}