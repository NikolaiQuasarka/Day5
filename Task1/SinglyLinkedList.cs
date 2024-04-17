using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    public class ListNode
    {
        public int Value { get; set; }
        public ListNode? Next { get; set; } =null;
    }
    public class SLList
    {
        public ListNode? head;

        public SLList() { head = null; Changing?.Invoke(this, new EventArgs()); }

        public static ListNode operator +(SLList list1, SLList list2)
        {
            SLList sLList = new SLList();
            for(ListNode i = list1.head;i!=null ;i=i.Next )
            {
                    sLList.AddItem(i.Value);                  
            }
            for (ListNode i = list2.head; i != null; i = i.Next)
            {
                    sLList.AddItem(i.Value);
            }
            return sLList.head;
        }

        public static SLList operator --(SLList list)
        {
            list.head = list.head?.Next;
            list.Changing?.Invoke(list, new EventArgs());
            return list;
            
        }

        public static bool operator ==(SLList list1, SLList list2)
        {
            
                for (ListNode? i = list1.head, j = list2.head; i != null || j != null; i = i?.Next, j = j?.Next)
                {
                    if (i == null || j == null || !(i.Value==j.Value))
                        return false;
                }
                return true;
            
        }
        public static bool operator !=(SLList list1, SLList list2)
        {
            for (ListNode? i = list1.head, j = list2.head; i != null || j != null; i = i?.Next, j = j?.Next)
            {
                if (i == null || j == null || !(i.Value == j.Value))
                    return true;
            }
            return false;
        }
        
        public static bool operator true(SLList list)
        {
            return list.head == null;
        }
        public static bool operator false(SLList list)
        {
            return list.head != null;
        }

        public void AddItem(int item)
        {
            if (head != null)
                LastItem().Next = new ListNode() { Value = item, Next=null};
            else { head = new ListNode() { Value=item, Next = null }; }
            Changing?.Invoke(this, new EventArgs());
        }
        public ListNode? LastItem()
        {
            if (head != null)
                for (ListNode i = head; i != null; i = i.Next)
                {
                    if (i.Next == null) return i;
                }
            return null;
        }

        public void DeleteItem(uint index)
        {
            if (head != null)
            {
                uint j = 0;
                for(ListNode i = head, previos=null; i != null |j<=0; i=i.Next, ++j)
                {
                    if (j == index) { previos.Next = i.Next; break; }
                    else previos = i;
                }
                    
                    Changing?.Invoke(this, new EventArgs());
            }
        }


        public delegate void EventHandler(object sender, EventArgs e);
        public event EventHandler? Changing;



        
        public Information information= new Information();


    }
public class Information
        {
            private static uint count = 0;
            public uint id { get; }
            string name { get; }
            public string Date {get;}
            public Information() {
                count++;
                id=count;
                name=Environment.UserName;
                Date = DateTime.Now.ToString();
            }
        }

    internal static class StaticOperation
    {
        public static int Sum(SLList list)
        {
            int sum = 0;
            for(ListNode? i = list.head;i!=null; i = i.Next)
            {
                sum += i.Value;
            }
            return sum;
        }
        public static int Count(SLList list)
        {
            int count = 0;
            for(ListNode? i = list.head; i!=null; i = i.Next) { count += i.Value; }
            return count;
        }
        public static int Difference(SLList list)
        {
            if (list.head == null)
            {
                return 0;
            }

            int min = list.head.Value;
            int max = list.head.Value;

            for (ListNode? i = list.head.Next; i != null; i = i.Next)
            {
                if (i.Value < min)
                {
                    min = i.Value;
                }
                else if (i.Value > max)
                {
                    max = i.Value;
                }
            }

            return Math.Abs(max - min);
        }
    }
}
