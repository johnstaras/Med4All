using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Syntagh
{
    public class aksiologhseis
    {
        float asteria;
        string keimeno;

        void create_aksiologhsh()
        {
            string sxolio;
            float stars;
            sxolio = Console.ReadLine();
            stars = float.Parse(Console.ReadLine());
            if (stars < 0)
            {
                stars = 0;
            }
            else if (stars > 5)
            {
                stars = 5;
            }

            this.asteria = stars;
            this.keimeno = sxolio;

        }
    }
}
