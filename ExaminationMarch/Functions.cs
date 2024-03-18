using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ExaminationMarch
{
    internal class Functions<T>// where T : IComparable<T>
    {
        public Node<T> first;
        public Functions()
        {
            first = null;
        }

        //variabels I'll be using
        public string[] var = { "integer (int)", "charachter (char)", "text (string)" }; 
        string input;
        int num;
        char chara;
        bool InputValid;
        public void RemoveFirst()
        {
            Console.WriteLine("The first value of the list has been deleted.");
            first = first.next;
        }

        public void AddInt() // add bool + while loop so it'll repeat if the input is invalid! 
        {
         //  while(InputValid == false) //loop until valid input // didn't work, stuck in loop
            {
                Console.WriteLine($"Enter an {var[0]} to add to the list: ");
                input = Console.ReadLine(); // Read input from the user as a string
                if (int.TryParse(input, out num)) // Try parsing the string input to an int
                {
                    Console.WriteLine($"You've entered the integer: {num}.");
                    T data = ((T)Convert.ChangeType(num, typeof(T)));
                   // InputValid = true;
                    AddToList();
                }
                else
                {
                    Console.WriteLine("Input couldn't be converted to int, please try again.");
                   // InputValid = false;
                }
            }

        }
        public void AddChar() 
        {
            Console.WriteLine($"Enter an {var[1]} to add to the list: ");
            chara = Console.ReadLine()[0];
                Console.WriteLine($"You've entered the charachter: {chara}.");
            T data = (T)Convert.ChangeType(chara, typeof(T)); // Convert char to T 
            AddToList();
        }
        public void AddString()
        {
            Console.WriteLine($"Enter an {var[2]} to add to the list: ");
            input = Console.ReadLine();
                Console.WriteLine($"You've entered the text: {input}.");
            T data = (T)Convert.ChangeType(input, typeof(T)); // Convert string to T 
            AddToList();
        }
        private void AddToList()
        {
            T data = GenerateData(); //this is probably the issue.
            if (first == null)
                first = new Node<T>(data); //if the first is empty add Data there
            else
            {
                Node<T> current = first; //if not, add it at the end of the list (when we find null)
                while (current.next != null) 
                {
                    current = current.next;
                }
                current.next = new Node<T>(data);
            }
        }
        private T GenerateData() //used in AddToList 
        {   
            return default(T); 
        }
        public bool RemoveValue(T data) //need to make it so we ask the user what value they want removed
        {
            Node<T> current = first;
            Node<T> previous = null; //keeps track of the previous value
            while (current != null)
            {
                if (current.value.Equals(data)) //if the value we're looking for exists run this
                {
                    if (previous == null) //if the first value is the one to be removed
                    {
                        first = current.next;
                    }
                    else 
                    {
                        previous.next = current.next; //skips the value we want removed and therby removes it                   
                    }
                    Console.WriteLine("The value " + data + " has been removed.");
                    return true;
                }
                else
                {
                    previous = current;
                    current = current.next; //moves both current and previous one step forward
                }
            }
            //if the input didn't exist 
            Console.WriteLine("The value " + data + " does not exist and therefore cannot be removed.");
            return false;
        }
        public void PrintInt() //wanted to move these specific ones to StartProgram but then Program didn't work
        {
            Console.WriteLine($"This is the whole {var[0]} list: ");
            Print();
        }
        public void PrintChar()
        {
            Console.WriteLine($"This is the whole {var[1]} list: ");
            Print();
        }
        public void PrintString()
        {
            Console.WriteLine($"This is the whole {var[2]} list: ");
            Print();
        }
        protected void Print()
        {
            Node<T> current = first;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
      
        public void AddTry(T data) //don't want to use this one since it's a direct copy but have it to check values for now
        {
            if (first == null)
                first = new Node<T>(data); //if the first is empty add data there
            else
            {
                Node<T> current = first; //if not, add it at the end of the list (when we find null)
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node<T>(data);
            }
        }
        public void Sort() 
        {
            
        }
    }
   
}
internal class Node<T> // direct copy. Using for now to get started
{
    public T value { get; set; }
    public Node<T> next { get; set; }
    public Node(T data)
    {
        this.value = data;
        this.next = null;
    }
   
}

