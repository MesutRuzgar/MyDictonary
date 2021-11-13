using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace MyDictonary
{
    class MyDictonary<Tid, Tname>
    {
        Tid[] ids;
        Tname[] names;

        public MyDictonary()
        {
            ids = new Tid[0];
            names = new Tname[0];
        }
               
        public void Add(Tid id, Tname name)
        {
            Tid[] tempId = ids;
            ids = new Tid[ids.Length + 1];
            Tname[] tempName = names;
            names = new Tname[names.Length + 1];

            for (int i = 0; i < tempId.Length; i++)
            {
                ids[i] = tempId[i];
                names[i] = tempName[i];
            }
            ids[ids.Length - 1] = id;
            names[names.Length - 1] = name;
                      
            Console.WriteLine("Id : " + id + "        Name : " + name);
        }

    }

}



