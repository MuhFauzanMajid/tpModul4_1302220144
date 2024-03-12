using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302220144
{
    enum DoorState
    {
        Terkunci,
        Terbuka
    }
    class DoorMachine
    {
        private DoorState currentState;

        public DoorMachine()
        {
            // State awal adalah Terkunci
            currentState = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            if (currentState == DoorState.Terkunci)
            {
                currentState = DoorState.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah tidak terkunci");
            }
        }

        public void KunciPintu()
        {
            if (currentState == DoorState.Terbuka)
            {
                currentState = DoorState.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }
    }

}
