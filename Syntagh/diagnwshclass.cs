using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntagh
{
    public class diagnwshclass
    {
        float pyretos, nero;
        int hlikia;
        Boolean ponokefalos;
        string symperasma;

        public string evaluate_symptoms()
        {
            string diagnwsh = "";
            if (hlikia < 50)
            {
                if (this.ponokefalos == true & this.pyretos > 36.6)
                {
                    if (nero > 1)
                    {
                        diagnwsh = "Κρύωμα";
                    }
                    else
                    {
                        diagnwsh = "Αφυδάτωση";
                    }
                }
                else if (this.ponokefalos == true & this.pyretos == 36.6)
                {
                    diagnwsh = "Κόπωση΄";
                }
            }else
            {
                if (this.ponokefalos == true & this.pyretos > 36.6)
                {
                    if (nero > 1)
                    {
                        diagnwsh = "Ίωση";
                    }
                    else
                    {
                        diagnwsh = "Ηλίαση";
                    }
                }
                else if (this.ponokefalos == true & this.pyretos == 36.6)
                {
                        diagnwsh = "Ίλιγγος";
                }

            }
            return diagnwsh;
        }
    }
}
