using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntagh
{
    public class Synergates : logariasmoi
    {
        private int kwdikos_synergasias;

        private int thlefwno;

        private string topothesia;

        private string specific_type;

        private string wres_leitourgias;

        private string onoma_katasthmatos;


        public void create_synergates(int thlefwno, string topothesia, string specific_type, string wres_leitourgias, string onoma_katasthmatos)
        {
            this.thlefwno = thlefwno;
            this.topothesia=topothesia;
            this.specific_type=specific_type;
            this.wres_leitourgias= wres_leitourgias;
            this.onoma_katasthmatos=onoma_katasthmatos;

         }

        public int checkCredential(int kwdikos_synergasias)
         {
            int a = 0;
         // tsekaroyme ean o kwdikos gia thn dhmiourgia toy synergath einai swstos
            if (this.kwdikos_synergasias==kwdikos_synergasias ) {
                a = 1;
         }
            return a;
        }
        public string get_doctors(id)
           {
            string timh = "doctor";
            string[] doctors;
            for (int i = 0; i < id; i++)
            {
                if (specific_type == timh)
                {
                    doctors[i] = onoma_katasthmatos;
                }
            }
            return doctors[];
        }
        public string get_Farmakeia(id)
        {
            string[] farmakeia;
            for (int i = 0; i < id; i++)
            {
                if (specific_type == 'farmakopoios')
                {
                    farmakeia[i] = onoma_katasthmatos;
                }
            }
            return farmakeia[];
        }






    }
}
