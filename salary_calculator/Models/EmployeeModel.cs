using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace salary_calculator.Models
{
    public class EmployeeModel
    {
        //Get values from user
        [Range(1, 4, ErrorMessage = "Level must be between 1-4")]
        public int Level { get; set; }

        [Range(500, double.MaxValue, ErrorMessage = "Basic Salary must be greater than 500")]
        public decimal BasicSalary { get; set; }

        //Return value to user
        public decimal NetSalary;

        //Calculate the values internally
        private decimal _perks;

        private decimal _houseRentAllowance;

        private decimal _grossSalary;

        private decimal _conveyanceAllowance;
        private decimal ConveyanceAllowance
        {
            get { return _conveyanceAllowance; }
            set
            {
                _conveyanceAllowance = Level switch
                {
                    1 => 10000,
                    2 => 7500,
                    3 => 5000,
                    4 => 2500,
                    _ => 0
                };
            }
        }

        private decimal _entertainmentAllowance;
        private decimal EntertainmentAllowance
        {
            get { return _entertainmentAllowance; }
            set
            {
                _entertainmentAllowance = Level switch
                {
                    1 => 5000,
                    2 => 2000,
                    3 => 1000,
                    _ => 0
                };
            }
        }

        private decimal _taxRate, _taxDeducted;

        public decimal CalculateNetSalary()
        {
            //Calculate perks based on level
            // Initializers triggers the set property else never triggered and it will always remain 0
            ConveyanceAllowance = 0;
            EntertainmentAllowance = 0;

            _perks = _conveyanceAllowance + _entertainmentAllowance;

            //Calculate HRA based on basic salary
            _houseRentAllowance = BasicSalary * 0.25m;

            //Calculate gross salary of the employee
            _grossSalary = BasicSalary + _houseRentAllowance + _perks;

            //Evaluate tax rate based on gross salary
            _taxRate = _grossSalary switch
            {
                > 20000 and <= 40000 => 3,
                > 40000 and <= 50000 => 5,
                > 50000 => 8,
                _ => 0
            };

            _taxDeducted = (_grossSalary * _taxRate) / 100.0m;

            NetSalary = _grossSalary - _taxDeducted;

            return NetSalary;
        }

    }
}
