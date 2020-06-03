using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntagh
{
    class paraggelia
    {
        private string onoma_pelath;
        private string onoma_farmakopoiou;
        private float xronos_etoimothtas;
        private int id;


        public void addPaggelia(int id, string onoma_pelath, string onoma_farmakopoiou, float xronos_etoimothtas)
        {
            this.onoma_pelath = onoma_pelath;
            this.onoma_farmakopoiou = onoma_farmakopoiou;
            this.xronos_etoimothtas = xronos_etoimothtas;
            this.id = id;
        }

    }
}
