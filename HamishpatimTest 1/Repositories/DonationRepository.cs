using HamishpatimTest_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HamishpatimTest_1.Repositories

{
    public class DonationRepository : IRepository<Donation>
    {

        
            private readonly IContext _context;
            public DonationRepository(IContext context)
            {
                _context = context;
            }

            public void AddItem(Donation item)
            {
                _context.Donations.Add(item);
                _context.SaveChanges();
            }

            public void DeleteItem(int id)
            {
                _context.Donations.Remove(get(id));
                _context.SaveChanges();
            }

        public Donation get(int id)
        {
            return _context.Donations.FirstOrDefault(x => x.Id == id) ?? new Donation();
        }

        public List<Donation> getAll()
            {
                return _context.Donations;
            }

            public void UpdateItem(int id, Donation donation)
            {
                Donation d = get(id);
                d.Donor = donation.Donor;
                d.Amount = donation.Amount;
                d.DonorType = donation.DonorType;
                d.Purpose = donation.Purpose;
                d.Conditions = donation.Conditions;
            d.Currency = donation.Currency;
            d.ExchangeRate = donation.ExchangeRate;

            _context.SaveChanges();
            }
        }
    }




