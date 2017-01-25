using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerShoppingCar
{
    class Customer
    {
        public string customerNmae
        {

            get
            {
                return customerNmae;
            }

            set
            {
                customerNmae = value;
            }
        }
           
        public string credicCardInfo
        {

            get
            {
                return credicCardInfo;
            }

            set
            {
                credicCardInfo = value;
            }
        }
        public string ShippingInfo
        {

            get
            {
                return ShippingInfo;
            }

            set
            {
                ShippingInfo = value;
            }
        }



        public Customer (string customerName,string credicCardInfo,string ShippingInfo)
        {

        }
        
        public string UpdateProfile()
        {
            return " ";
        }

    }
}
