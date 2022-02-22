public class XSClubPromoter : Promoter, IBodyBuilder, IVlogger
{
    

    public XSClubPromoter(string firstName, string lastName, long cellphone) : base(firstName, lastName, cellphone)
    {

    }

   

    protected override void ShareWithInnerCircle()
    {
         Console.WriteLine("I share with my instagram followers");
    }

    protected override void UsePaidAds()
    {
        Console.WriteLine("I use facebook ads");
    }
    
    public void Vlog()
    {
         Console.WriteLine("I use DSLR to vlog");
    }
     public void Workout()
    {
  Console.WriteLine("I workout at my house");
    }
    
}