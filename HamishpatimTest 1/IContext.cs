using HamishpatimTest_1.Models;

namespace HamishpatimTest_1
{
       public interface IContext
        {
            public List<Donation> Donations { get; set; }
            
            public void SaveChanges();
        }
    }

