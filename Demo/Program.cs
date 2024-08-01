using System.Collections;

namespace ConsoleApp1
{

    class movie
    {
        public int id { get; set; }
        public string tittle { get; set; }
        public decimal price { get; set; }

        public override string ToString()
        {
            return $"{id} :: {tittle} :: {price}";
        }

        public override int GetHashCode()
        {
            return id.GetHashCode() ^ tittle.GetHashCode() ^ price.GetHashCode();
        }


        public override bool Equals(object? obj)
        {
            movie movie = obj as movie;
            if (movie == null)
                return false;
            return this.id.Equals(movie.id) && this.tittle.Equals(movie.tittle)
                && this.price.Equals(movie.price);
        }

    }
    internal class Program
    {
        public static int SumArrayList(ArrayList arrayList)
        {
            int sum = 0;
            if (arrayList != null)
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    sum += (int?)arrayList[i] ?? 0; // casting from object
                                                    // [ref type] to int [value type] => unBoxing

                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            #region ArrayList
            //ArrayList arrayList = new ArrayList();

            //Console.WriteLine($"count = {arrayList.Count} , capacity = {arrayList.Capacity} ");
            //arrayList.Add(1);
            //Console.WriteLine($"count = {arrayList.Count} , capacity = {arrayList.Capacity} ");
            //arrayList.Add(2);
            //arrayList.AddRange(new int[] { 3, 4 });
            //Console.WriteLine($"count = {arrayList.Count} , capacity = {arrayList.Capacity} ");

            //arrayList.Add(5);
            //Console.WriteLine($"count = {arrayList.Count} , capacity = {arrayList.Capacity} ");

            //// release | delete | free unused bytes 
            //arrayList.TrimToSize();
            //Console.WriteLine($"count = {arrayList.Count} , capacity = {arrayList.Capacity} ");



            // ArrayList arrayList2 = new ArrayList();
            // arrayList2.Add(1); // casting from int [value type ] to object [ref type] => boxing
            // arrayList2.Add(2);
            // arrayList2.Add(3);
            // arrayList2.Add(4);
            // arrayList2.Add(5);
            //// Console.WriteLine($"count = {arrayList2.Count} , capacity = {arrayList2.Capacity} ");
            // arrayList2.Add(6);
            // //Console.WriteLine($"count = {arrayList2.Count} , capacity = {arrayList2.Capacity} ");
            // //compilar can not enforce type safety
            // arrayList2.Add("hamadaaaa");


            // // unboxing 
            // //foreach( int i in arrayList2)
            // //{
            // //    Console.WriteLine(i);
            // //}


            // int result = SumArrayList(arrayList2);
            // Console.WriteLine($"sum = {result}");



            #endregion

            #region List
            //List<int> numbers = new List<int>();

            //Console.WriteLine($"count = {numbers.Count} , capacity = {numbers.Capacity} ");

            //numbers.Add(1); // no boxing
            //Console.WriteLine($"count = {numbers.Count} , capacity = {numbers.Capacity} ");

            //numbers.AddRange(new int[] { 2, 3, 4 });
            //Console.WriteLine($"count = {numbers.Count} , capacity = {numbers.Capacity} ");

            //numbers.Add(5);
            //Console.WriteLine($"count = {numbers.Count} , capacity = {numbers.Capacity} ");




            //numbers.TrimExcess();
            //Console.WriteLine($"count = {numbers.Count} , capacity = {numbers.Capacity} ");

            ////list.Add(1);
            ////list.Add(2);
            ////list.Add(3);
            ////list.Add(4);
            ////list.Add(5);
            //Console.WriteLine($"count = {list.Count} , capacity = {list.Capacity} ");

            //list.Add(6);
            //Console.WriteLine($"count = {list.Count} , capacity = {list.Capacity} ");
            //list.Add("hamadaaa"); // compilar enforce type safety

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}


            //list[2] = 100; // use indexer as set

            //Console.WriteLine(list[2]); // use indexer as get 

            //list[4] = 5; // use ndexer for adding  [invalid]

            //List<int> list2 = Enumerable.Range(1, 10).ToList();

            #endregion

            #region LinkedList
            //LinkedList<int> linkedList = new LinkedList<int>();

            ////Console.WriteLine($"count = {linkedList.Count}");

            //linkedList.AddFirst(1);

            //linkedList.AddLast(2);
            ////Console.WriteLine($"count = {linkedList.Count}");




            //LinkedListNode<int> node = linkedList.Find(2);

            //linkedList.AddAfter(linkedList.Find(2), 110);



            //linkedList.AddBefore(linkedList.Find(2), 300);


            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Stack
            //Stack<int> stack = new Stack<int>();
            ////last in frst out [LIFO]

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //stack.Peek(); // 3 
            //// return element in the top without removing 

            //Console.WriteLine(stack.Peek());

            //stack.Pop(); // return element in the top with removing 
            //             // 3 

            //Console.WriteLine(stack.Peek()); // 2 


            #endregion

            #region Queue
            //Queue<int> queue = new Queue<int>();
            //// first in first out [FIFO]



            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //Console.WriteLine(queue.Dequeue()); // return element at start of queue
            //                                    // then remove it

            //Console.WriteLine(queue.Peek()); // return element at start of queue
            //                                 // without remove it


            #endregion



















        }
    }
}