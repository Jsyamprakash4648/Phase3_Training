using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public partial class CustomizedList<Type>

    {

        private int _count=0;
        private int _capacity;

        private Type[] _array;
        public int Count { get{return _count;} }
        public int Capacity { get{return _capacity;} }

          public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index]=value; }
        }



        public   CustomizedList()
        {
            _capacity=4;
            _count=0;
            _array=new Type[_capacity];
            

        }
        
        public   CustomizedList(int size)
        {
            _capacity=size;
            _count=0;
            _array=new Type[_capacity];
             

        }



        public void  Add(Type values)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            _array[_count]=values;
            _count++;
        
           
        }

        
        public void  GrowSize()
        {
            _capacity=2*_capacity;

            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];

            }
            _array=temp;
        

        }

        public  void  AddRange(CustomizedList<Type> values)
        {
           
             _capacity=_capacity+values.Count+4;

            Type[] temp=new Type[_capacity];
            for (int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }

            int k=0;

            for(int j=_count;j<_count+values.Count;j++)
            {
                temp[j]=_array[k];
                k++;

            }

            _array=temp;
            _count=_count+values.Count;

        }


        
        
    }
}

