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
        }



        public void delete_account(int id)
        {

            delete_all(id);

        }





    }
}
