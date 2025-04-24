using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_simple_interest
{
    public class Calculate_SI
    {
        public int PrincipalAmount { get; set; }
        public int YrsOfInvestment { get; set; }
        private decimal rateOfInterest;

        public decimal RateOfInterest
        {
            get { return rateOfInterest; }
            set
            {
                if (value <= 0 || value > 40)
                {
                    string ErrorMsg = $"The interest {rateOfInterest} is invalid." +
                        $"Please enter interest between 1 - 40";
                    throw new Exception(ErrorMsg);
                }
                rateOfInterest = value;
            }
        }

        private string companyName = "FinServices";
        public string CompanyName
        {
            get
            {
                return companyName;
            }
        }

        private decimal simpleInterest;
        public decimal SimpleInterest => simpleInterest;  //read-only operator as arrow property
        
        public void CalculateInterest()
        {
            simpleInterest = PrincipalAmount * YrsOfInvestment * RateOfInterest / 100M;
        }

    }
}
