public class OmniaClubPromoters : Promoter
{
    public OmniaClubPromoters(string firstName, string lastName, int cellphone) : base(firstName, lastName, cellphone)
    {
    }

    protected override void ShareWithInnerCircle()
    {
Console.WriteLine("I shared with my friends");
    }

    protected override void UsePaidAds()
    {
        Console.WriteLine("I use google ads");
    }
}