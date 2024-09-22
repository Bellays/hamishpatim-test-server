

using HamishpatimTest_1.Models;

namespace HamishpatimTest_1
{
    public class DonationsDB : IContext
    {
        public List<Donation> Donations { get; set; }
        public void SaveChanges()
            {

            }

            public DonationsDB()
            {
                Donations = new List<Donation>()
            {
                new Donation { Id = 1, Donor = "Shimon", Amount = 5896, DonorType = "jnjkbh", Purpose = "jkbgcf", Conditions = "jlkjhjg" ,Currency="fff",ExchangeRate=789},
                new Donation { Id = 2, Donor = "Bella", Amount = 5896, DonorType = "jnjkbh", Purpose = "jkbgcf", Conditions = "jlkjhjg" ,Currency="fff",ExchangeRate=789},
                new Donation { Id = 3, Donor = "Dvora", Amount = 5896, DonorType = "jnjkbh", Purpose = "jkbgcf", Conditions = "jlkjhjg" ,Currency="fff",ExchangeRate=789},
            };            
            }
        }
    }


