﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_020
{
    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

       public Program()
        {
            /*Initializing the values of the variables REAR and FRONT to -1 to indicate
             * the queue is initially empty.*/
            FRONT = -1;
            REAR = -1;
        }
        public void insert (int element)
        {
            /*This statement checks for the overflow condition.*/
            if ((FRONT == 0 && REAR == max -1 ) || (FRONT == REAR +1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            /* This following statement checks whether the queue is empty. If the queue
             * , then the value of the REAR and FRONT variables is set to 0 */
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                /* If REAR is at the last position of the array,the the value of
                 * REAR is set to 0 that corresponds to the first position of the array. */
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /* If REAR is not at the last position, then its value is incremented by one */
                    REAR = REAR + 1;
            }
            /* Once the position of REAR is determined, the element is added at its proper place. */
            queue_array[REAR] = element;
        }
        public void remove()
        {
            /* CHecks wheather the queue is empty. */
            if (FRONT == -1)
            { 
                Console.WriteLine("Queue underflow\n");
                return ;
            }
            Console.WriteLine("\nThe Element deleted from the queue is: " + queue_array[FRONT] + "\n");
            /* Check if the queue has one element. */
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                /* If the element to be deleted is at the last position of the array, then the value 
                 * of FRONT is set to 0 i.e to the first element of the array. */
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                    /*FRONT is increnebted by one if it is not the first element of array. */
                    FRONT = FRONT + 1;
            }
        }
        public void display()
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
