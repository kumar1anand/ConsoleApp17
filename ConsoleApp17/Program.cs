namespace anand
{
    internal class Prpogram
    {
        static void Main()
        {
            /*var sort= new SortedSet<string>()
            {
                "anand",
                "kumar",
                "anand"
            };
            foreach (var item in sort)
            {
                Console.WriteLine(item);
            }*/

            /*Stack<int> s= new Stack<int>();
            s.Push(1);
            s.Push(2);
            foreach(int i in s)
            {
                Console.WriteLine(i);
            }
            int a= s.Peek();
            Console.WriteLine(s.Count == 0);*/



            /*Queue<string> q = new Queue<string>();
            
            q.Enqueue("monday");
            q.Enqueue("tue");
            q.Enqueue("thrus");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            q.Dequeue();
            Console.WriteLine("");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(q.Peek());*/


           /* var l = new LinkedList<int>();
            l.AddLast(1);
            l.AddLast(2);
            l.AddFirst(3);
            l.AddFirst(4);
            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
            LinkedListNode<int> node = l.Find(4);
            l.AddAfter(node,10);
             Console.WriteLine("");
            Console.WriteLine("");
            LinkedListNode<int> o= l.Find(3);
            Console.WriteLine(o.Value);
            Console.WriteLine("");
            Console.WriteLine("");
            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(o.Next.Value);*/

            /*Dictionary<string, int> m = new Dictionary<string, int>();
            m.Add("anand",1);
            m.Add("shiva", 2);
            m.Add("heloo", 3);


            foreach (KeyValuePair<string, int> pair in m)
            {
               Console.WriteLine(pair.Key+" "+ pair.Value);
            }
            m.Remove("anand");
            string a= m.Keys.Min();*/
            
            
            
            /*SortedList<string,string> l = new SortedList<string,string>();
            l.Add("anand", "kumar");
            l.Add("ankit", "kuwar");
            l.Add("Virat", "kholi");
            l.Add("aaaaa", "zzzzz");
            foreach(KeyValuePair<string,string> pair in l)
            {
                Console.WriteLine(pair.Key+" "+pair.Value);
            }*/


            SortedDictionary<int, int> map = new SortedDictionary<int, int>();  
            map.Add(1, 2);
            map.Add(2, 3);
            map.Add(3, 4);
            map.Add(4, 5);
            map.Add(2, 3);
            map.Add(3, 4);
            map.Add(2, 3);          
            map.Add(5, 6);
            map.Add(6, 7);
            foreach (KeyValuePair<int,int> pair in map)
            {
                Console.WriteLine(pair.Value+" "+pair.Key);
            }



        }
    }
}