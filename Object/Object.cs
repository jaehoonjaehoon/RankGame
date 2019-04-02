using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankGame.Object
{
    class Object
    {
        private string name { get; set; }
        private int score { get; set; }

        public Object(string _n, int _s = 0)
        {
            name = _n;
            score = _s;
        }

    }
}
