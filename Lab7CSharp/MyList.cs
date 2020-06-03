using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab7CSharp
{
    public class MyList
    {
        Node head; 
        Node tail; 
        int count;  
        public void Add(float data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;
            count++;
        }
        public void Remove(float data)
        {
            Node current = head;
            Node previous = null;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    count--; 
                }
                previous = current;
                current = current.Next;
            }            
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public void AppendLast(float data)
        {
            Node node = new Node(data);
            tail.Next = node;
            tail = node;
            if (count == 0)
                tail = head;
            count++;
        }
        public IEnumerator GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        public int CountMoreThan(float a)
        {
            int count1=0;
            foreach (float item in this)
            {
                if (item > a) count1++;
            }
            return count1;
        }
    }
}
