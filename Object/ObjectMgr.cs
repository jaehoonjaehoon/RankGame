using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankGame.Object
{
    class ObjectMgr
    {
        public static ObjectMgr instance;

        private List<Object> objects { get; set; }

        private ObjectMgr()
        {
            objects = new List<Object>();
        }

        public List<Object> GetObjects()
        {
            return objects;
        }

        public static ObjectMgr GetInstance()
        {
            if( null == instance )
            {
                instance = new ObjectMgr();
            }
            return instance;
        }

        public void Add(Object ele)
        {
            objects.Add(ele);
        }

        public void Remove(Object ele)
        {
            objects.Remove(ele);
        }

        public void RemoveAll()
        {
            objects.Clear();
        }
    }
}
