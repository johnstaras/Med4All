using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Syntagh
{
    public class rantevou
    {
        string onoma_giatrou, onoma_pelath, hmeromhnia_kai_wra;
        int id;

        static string get_wres()
        {
            string wres_giatrou = Giatros.check_hours();
            return wres_giatrou;
        }
        void create_appointment()
        {
            onoma_giatrou = this.onoma_giatrou;
            onoma_pelath = this.onoma_pelath;
            hmeromhnia_kai_wra = this.hmeromhnia_kai_wra;
        }
        void call_appointment()
        {
            string call_giatros = this.onoma_giatrou;
            string call_pelaths = this.onoma_pelath;
        }
    }
}
