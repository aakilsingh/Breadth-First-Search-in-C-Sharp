using System.Collections;

namespace Breadth_First_Search
{

    public class Program
    {
        public static void breadthFirstPrint(Dictionary<string, List<string>> graph, string src)
        {

            // since we are doing a breadth first search we use a queue, this queue stores our nodes, FIFO
            //src is the starting node
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(src);
            

            while (queue.Count != 0)
            {
                // gets current node
                string node = queue.Dequeue();
                Console.WriteLine(node);

                // gets the neighbours of current node and adds them to the queue
                var neighbours = graph.GetValueOrDefault(node);
                foreach (var neighbour in neighbours)
                {
                    queue.Enqueue(neighbour);
                }
            }
        }

        public static void Main(string[] args)
        {
            // key is the node
            // value is the list of neighbours of the node (list of other nodes)
            Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>
            {
                {"a",new List<string>{"b","c" } },
                {"b", new List<string>{"d"} },
                {"c",new List<string>{"e"} },
                {"d",new List<string>{} },
                {"e",new List<string>{} },
            };

            breadthFirstPrint(graph, "a");
        }
    }
}
