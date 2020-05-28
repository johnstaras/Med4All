using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntagh
{
    public class user : logariasmoi
    {


        private string iatroi_mou;

        private string eksetaseis;

        private string syntages;

        string[] mydoctors = new string[50000000];

        string[] mysyntages = new string[50000000];


        public string getProfile(id) {


            for (int i = 0; i < account.Length; i = i + 5)
            {
                if (account[i - 5] = id)
                {
                    id = account[i - 5];
                    password = account[i - 4];
                    email = account[i - 3];
                    type_of_relation = account[i - 2];
                    first_name = account[i - 1];
                    surname = account[i];

                    onoma_pelath = surname;
                    topothesia = type_of_relation;

                    return onoma_pelath,topothesia;

                }
                else {
                    Console.WriteLine("account no found");
                }
            }
        }


        public string add_doctors(id,onoma_giatrou)
        {
            for (int i = 0; i < account.Length; i = i + 5)
            {
                if (account[i - 5] = id)
                {

                    for (int i = 0; i < mydoctors.Length; i = i + 2)
                    {
                        mydoctors[i-1] = id;
                        mydoctors[i] = onoma_giatrou;

                    }
                }
            }
        }
        
        public string my_doctors(id)
        {

            for (int i = 0; i < mydoctors.Length; i = i + 2)
            {
                if (mydoctors[i - 1] = id)
                {

                    onoma_giatrou = mydoctors[i];
                    return onoma_giatrou;
                }
                else {


                    Console.WriteLine("no found");

                }

            }



        }

        public string add_syntagh(id, syntages)
        {

            for (int i = 0; i < mysyntages.Length; i = i + 2)
            {
                mysyntages[i - 1] = id;
                mysyntages[i] = syntages;
            }
        }
        public string get_my_syntages(id)
        {

            for (int i = 0; i < mysyntages.Length; i = i + 2)
            {
                if (mysyntages[i - 1] = id)
                {

                    syntages = mysyntages[i];
                    return syntages;
                }
                else {

                    Console.WriteLine("no found syntages");


                }


            }

        }






    }
}
