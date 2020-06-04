using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntagh
{
    class Farmakopoios : Synergates
    {
        private bool avalailable;
        private bool approve1;
        public bool available()
        {

            return this.avalailable;
        }


        public bool approve()
        {

            return this.approve1;
        }
    }
}
