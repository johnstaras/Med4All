using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntagh
{
    class logariasmoi
    {
        private int id;
        private string email;


        public void create_account(int id, string password, string email, string type_of_relation, string first_name, string surname)
        {

            this.id = id;
            this.password = password;
            this.email = email;
            this.type_of_relation = type_of_relation;
            this.first_name = first_name;
            this.surname = surname;

            string[] account = new string[50000000];

            for (int i = 0; i < account.Length; i = i + 5)
            {

                account[i - 5] = id;
                account[i - 4] = password;
                account[i - 3] = email;
                account[i - 2] = type_of_relation;
                account[i - 1] = first_name;
                account[i] = surname;
            }
        }



        public void delete_account(int id)
        {

            int iSearch = id;
            string foundIndex = account.ToList().IndexOf(iSearch);
            account = account.Where(val => val != foundIndex).ToArray();
        }





    }
}
