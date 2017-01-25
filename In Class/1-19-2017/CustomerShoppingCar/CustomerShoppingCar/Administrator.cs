using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerShoppingCar
{
    class Administrator:IUser
    {
        private string adminName;

        public string address
        {
            get
            {
                return address;
                //throw new NotImplementedException(); 专门用来throw exception
            }

            set
            {
                address = value;
            }
        }

        public string AdminName
        {

            get
            {
                return adminName;
            }

            set
            {
                adminName = value;
            }
        }

        public string cellPhone get
            {
                return adminName;
            }

            set
            {
                adminName = value;
            }

        public string email
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string firstName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string homePhone
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string lastName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string loginStatus
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string password
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string userid
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool UpdateCatalog()
        {
            return true;
        }

        public bool VerifyLogin()
        {
            throw new NotImplementedException();
        }
    }


}

