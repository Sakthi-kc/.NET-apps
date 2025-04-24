using calc_simple_interest;

string msg;

//Calculate Simple Interest for Asha

//Conventional method of assigning property

Calculate_SI InterestForAsha = new Calculate_SI();
InterestForAsha.PrincipalAmount = 500000;
InterestForAsha.YrsOfInvestment = 5;
InterestForAsha.RateOfInterest = 18.25M;

InterestForAsha.CalculateInterest();
decimal SI_For_Asha = InterestForAsha.SimpleInterest;

msg = $"Asha earned simple interest of {SI_For_Asha}";
Console.WriteLine(msg);

//Calculate Simple Interest for Bob

//Modern method of assigning property -> only when initiating an object

Calculate_SI InterestForBob = new Calculate_SI
{
    PrincipalAmount = 350000,
    YrsOfInvestment = 4,
    RateOfInterest = 31.75M,
};

InterestForBob.CalculateInterest();
decimal SI_For_Bob = InterestForBob.SimpleInterest;

msg = $"Asha earned simple interest of {SI_For_Bob}";
Console.WriteLine(msg);

if (SI_For_Asha > SI_For_Bob)
{
    Console.WriteLine("Asha earns more interest. The difference is {0}", SI_For_Asha - SI_For_Bob);
}
else
{
    Console.WriteLine("Bob earns more interest. The difference is {0}", SI_For_Asha - SI_For_Bob);
}
