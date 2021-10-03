using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluidConsoleApp.Entities.NIC
{
    public class ISICCodeNIC
    {
        public string ISIC_Code { get; set; }
    }

    public class OwnerNic
    {
        public long Owner_ID { get; set; }
        public int LK_Relation_Code { get; set; }
        public double Percentage { get; set; }
        public double Share { get; set; }
    }

    public class NicInput
    {
        public long Request_Number { get; set; }
        public long New_700_ID { get; set; }
        public string Firm_Name { get; set; }
        public int Firm_Nationality_Code { get; set; }
        public string Issue_DateU { get; set; }
        public string Expiry_DateU { get; set; }
        public int LK_CR_Type { get; set; }
        public int LK_CR_Location { get; set; }
        public int PO_Box { get; set; }
        public int Zip_Code { get; set; }
        public string Address { get; set; }
        public long Telephone { get; set; }
        public long Fax { get; set; }
        public double Capital { get; set; }
        public long? Main_CR_Number { get; set; }

        public void SetNationalNumber(string nationalNumber)
        {
            this.New_700_ID = long.Parse(nationalNumber);
        }
    }

}
