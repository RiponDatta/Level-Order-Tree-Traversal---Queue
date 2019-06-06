using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_Order_Tree_Traversal___Queue
{
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        public void PrintLevelOrder()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while(queue.Count != 0)
            {
                Node temp = queue.Dequeue();
                Console.Write(temp.Data + " ");

                if(temp.Left != null)
                {
                    queue.Enqueue(temp.Left);
                }

                if(temp.Right != null)
                {
                    queue.Enqueue(temp.Right);
                }
            }

        }
    }
}
