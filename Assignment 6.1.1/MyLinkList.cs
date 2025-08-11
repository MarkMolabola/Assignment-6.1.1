using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._1._1
{
    public class MyLinkList
    {

        private Node head;
        private Node tail;
        private int size;
        public int Size
        {
            get { return size; }
        }
        public MyLinkList()
        {
            head = null;
            tail = null;
            size = 0;
        }
        public bool IsEmpty()
        {
            return this.size == 0;
        }
        public void AddFirst(Houses value)
        {
            Node newNode = new Node(value);
            if (size == 0) // if the list is empty
            {
                tail = newNode; // also set tail to the new node
            }
            else
            {
                newNode.Next = head; // link the new node to the current head
            }
            head = newNode; // update head to the new node
            size++; // increment the size of the list
        }
        public void AddLast(Houses value)
        {
            Node newNode = new Node (value);
            if (size == 0) // if the list is empty
            {
                head = newNode;
            }
            else
            {
                tail.Next = newNode; // link the current tail to the new node
            }
            tail = newNode; // update tail to the new node
            size++; // increment the size of the list
        }
        public void AddAnywhere(Houses value, int position)
        {
            if (position <= 0 || position > size)
            {
                throw new ArgumentOutOfRangeException("Position is out of bounds.");
            }
            if (position == 1)
            {
                AddFirst(value);
                return;
            }
            else if (position == size+1)
            {
                AddLast(value);
                return;
            }
            else
            {
                Node newNode = new Node (value);
                Node temp = head;
                for (int i = 0; i < position - 2; i++)
                {
                    temp = temp.Next; // traverse to the node before the desired position
                }
                newNode.Next = temp.Next; // link the new node to the next node
                temp.Next = newNode; // link the previous node to the new node
                size++; // increment the size of the list
            }
        }

       

        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The list is empty.");
            }
            var value = head.Value; // assuming T can be converted to int
            head = head.Next; // move head to the next node
            size--; // decrement the size of the list
            if (size == 0) // if the list is now empty
            {
                tail = null; // also set tail to null
            }
           
        }
        public void RemoveLast()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The list is empty.");
            }
            if (size == 1) // if there's only one element
            {
                head = null; // set head to null
                tail = null; // set tail to null
            }
            else
            {
                Node temp = head;
                int i = 1;
                while (temp.Next != tail) // find the second last node
                {
                    temp = temp.Next;
                }
            }
            size--; // decrement the size of the list
        }

        public void RemoveAnywhere(int position)
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The list is empty.");
            }
            if (position <= 0 || position > size)
            {
                throw new ArgumentOutOfRangeException("Position is out of bounds.");
            }
            if (position == 1) // if removing the first node
            {
                RemoveFirst();
                return;
            }
            Node temp = head;
            for (int i = 0; i < position - 1; i++)
            {
                temp = temp.Next; // traverse to the node before the desired position
            }
            temp.Next = temp.Next.Next; // bypass the node to be removed
            size--; // decrement the size of the list
           
        }
        public void Display()
        {
            Node temp = head;  // temporary variable to traverse the list
            while (temp != null) // traverse the list
            {
               
                Console.Write(temp.Value);
               
                temp = temp.Next;
            }
            Console.WriteLine();
        }
        
        public bool Contains(Houses value)
        {
            Node search = head; // start from the head of the list
            while (search != null) // traverse the list
            {
                if (search.Value.Equals(value)) 
                {
                    return true; // value found
                }
                search = search.Next; // move to the next node
            }
            return false; // value not found in the list
        }
        public void Search(int houseNumber)
        {
            Node search = head; // start from the head of the list
            bool found = false; // flag to check if house is found
            while (search != null) // traverse the list
            {
                if (search.Value.HouseNumber == houseNumber)
                {
                    Console.WriteLine(search.Value); // return the house details if found
                    found = true; // set flag to true
                }
                search = search.Next; // move to the next node
            }
            if (!found)
            {
                Console.WriteLine("House not found.");
            }

        }
        

    }   
        
}
