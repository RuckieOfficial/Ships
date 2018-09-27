using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships {
    class Ship {
        public ShipType Shiptype { get; set; }
        public ShipState State { get; set; }
    }

    enum ShipType {
        Submarine,
        Destroyer,
        Cruiser,
    }

    enum ShipState {
        Flow,
        Hit,
        Destroyed,
    }
}
