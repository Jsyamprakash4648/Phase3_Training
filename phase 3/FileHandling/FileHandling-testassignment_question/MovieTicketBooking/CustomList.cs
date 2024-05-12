using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public partial class CustomList<Type>
    {
        
        private int _count;
        private int _capacity;

        public int Count { get{return _count;}  }
        public int Capacity{ get{return _capacity;}  }
        private Type[] _array;


        public CustomList()
        {
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }

        public CustomList(int size)
        {
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }



        public void Add(Type value)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            _array[_count]=value;
            _count++;

        }


        public void GrowSize()
        {
            _capacity=2*_capacity;

            Type[] temp=new Type[_capacity];

            for (int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;

        }



        public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index]=value;}

        }


        public void AddRange(CustomList<Type> elements)
        {
            _capacity=_count+elements.Count+4;
            Type[] temp=new Type[_capacity];

            
            for(int i=_count;i>0;i--)
            {
                temp[i]=_array[i];

            }
             int k=0;
            for(int i=_count+elements.Count;i<_count;i++)
            {
                temp[i]=elements[k];
                k++;
            }
            _array=temp;
            _count=_count+elements.Count;  

        }



    }
}