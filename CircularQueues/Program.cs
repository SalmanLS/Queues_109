using System;

namespace CircularQueues
{ 
    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Program()
        {
            //initializing the values of the variable REAR and FRONT to -1 to indicate that queue is initially empty.
            FRONT = -1;
            REAR = -1;
        }

        public void insert(int element)
        {
            /*This statement checks for the overflow condition. */
            if ((FRONT == 0 && REAR == max - 1)|| (FRONT == REAR +1))
            {
                Console.WriteLine("\n Queue overflow\n");
                return;
            }
            
        }

    }
}