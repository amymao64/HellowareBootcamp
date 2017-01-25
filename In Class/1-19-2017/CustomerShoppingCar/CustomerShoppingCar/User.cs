using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerShoppingCar
{
    interface IUser
    {
        string firstName { get; set; }
        string lastName { get; set; }
        string cellPhone { get; set; }
        string homePhone { get; set; }
        string email { get; set; }
        string address { get; set; }
        string userid { get; set; }
        string password { get; set; }
        string loginStatus { get; set; }
        bool VerifyLogin();
        


    }
}
