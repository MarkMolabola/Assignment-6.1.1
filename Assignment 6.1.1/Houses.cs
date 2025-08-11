using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._1._1
{
    public class Houses
    {
        public string HouseAddress { get; set; }
        public string HouseType { get; set; }
        public int HouseNumber { get; set; }

        public Houses(string Address, string houseType, int houseNumber)
        {
            HouseAddress = Address;
            HouseType = houseType;
            HouseNumber = houseNumber;
        }
       
       

        public override string ToString()
        {
            return $"House Number: {HouseNumber} \nHouse Address: {HouseAddress} \nHouse Type: {HouseType} \n-----------------------------------\n";
        }
    }
}
