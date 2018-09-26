using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Policko {
        public int Y { get; set; }
        public int X { get; set; }
        public State state { get; set; }

    }
    enum State {
        Empty,
        Placed,
        Missed,
        Hit,
    }
}
