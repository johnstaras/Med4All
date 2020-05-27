using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntagh
{
    class Syntagh
    {
        private string syntages;
        private string eksetaseis;
        private string created_from;
        private string created_for;
        private string expires;
        private int id;




        public void createForm(string syntages, string created_from, string expires, string created_for, int id)
        {
            this.syntages = syntages;
            this.eksetaseis = eksetaseis;
            this.created_from = created_from;
            this.created_for = created_for;
            this.expires = expires;
            this.id = id;
        }


        static int getSyntagh(int id)
        {
            return id;
        }

        static void UpdateForm(string syntages, string created_from, string expires, string created_for)
        {

        }

        static bool oloklhrwmenes(string syntages)
        {
            bool finished = true;
            return finished;

        }

    }
}
