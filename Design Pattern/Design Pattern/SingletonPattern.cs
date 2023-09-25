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
        //vatiable for holding instance
        private static SingletonPattern instance=null;
        public static SingletonPattern getIntance
        {
            get
            {//when intance is null then create new intance and return it otherwise return old instance
                if(instance == null)
                
                    instance = new SingletonPattern();
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
