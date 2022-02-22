// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
namespace App
{
    class Program
    {
     static void Main(String[] args)
    {
List<Promoter> promoters= new List<Promoter>(){new XSClubPromoter("John","Jones",6175555),new XSClubPromoter("John","Jones",6175555),new OmniaClubPromoters("Jane","Jones",6192222)};
  foreach(var Promoter in promoters)
  {
      Promoter.Promote();
  }
  List<Writer> Writers= new List<Writer>(){new BookWriter("John","Jones"),new BookWriter("John","Jones"),new BlogWriter("Jane","Jones")};  
  foreach(var Writer in Writers)
  {
      Writer.Write();
  }
  List<IBodyBuilder> bodyBuilders= new List<IBodyBuilder>(){new XSClubPromoter("John","Jones",6175555),new XSClubPromoter("John","Jones",6175555)};  
   foreach(var bodyBuilder in bodyBuilders)
  {
      bodyBuilder.Workout();
  }
   List<IVlogger> vloggers= new List<IVlogger>(){new XSClubPromoter("John","Jones",6175555),new BookWriter("John","Jones" )};  
   foreach(var vlogger in vloggers)
  {
      vlogger.Vlog();
  }
    }

}
}