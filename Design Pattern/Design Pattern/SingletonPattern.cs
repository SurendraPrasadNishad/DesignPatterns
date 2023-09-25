using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public sealed class SingletonPattern
    {
        private static int count=0;
        private static readonly object obj=new object() ;
        //vatiable for holding instance
        private static SingletonPattern instance=null;
        public static SingletonPattern getIntance
        {
            get
            {//lock are expensive so check null object before going to it
                if(instance == null)
                {
                    //lock will prevent from running both object at same time and 1 object only created in multi threaded 
                    lock (obj)
                    {
                        //when intance is null then create new intance and return it otherwise return old instance
                        if (instance == null)

                            instance = new SingletonPattern();
                    }
                }
               
                    return instance;
               
            }
        }
        //make constructor to private and sealed class so that it not inherited in and out of class  any more
        private SingletonPattern()
        {
            count++;
            Console.WriteLine("object creation for singleton class="+ count.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
