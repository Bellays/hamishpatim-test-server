using AutoMapper;
using HamishpatimTest_1.Models;
using HamishpatimTest_1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace HamishpatimTest_1.Services
{
    public class DonationService : IService<DonationDto>
    {
        private readonly IRepository<Donation> repository;
        private readonly IMapper mapper;
        public DonationService(IRepository<Donation> repository, IMapper _mapper)
        {
            this.repository = repository;
            this.mapper = _mapper;
        }

        public void AddItem(DonationDto item)
        {
            if ((Regex.IsMatch(item.Donor, @"^[א-תa-zA-Z]+$")) && item.Donor != null && item.Amount != null && item.Purpose != null && item.Currency != null && item.ExchangeRate != null)
            {

                repository.AddItem(mapper.Map<Donation>(item));
            }
            if (item.Amount > 10000)
            {
                //send email
            }
        }

        public void DeleteItem(int id)
        {
            repository.DeleteItem(id);
        }

        public List<DonationDto> GetAll()
        {
            return mapper.Map<List<DonationDto>>(repository.getAll());
        }

        public DonationDto GetById(int id)
        {
            return mapper.Map<DonationDto>(repository.get(id));
        }

        public void UpdateItem(int id, DonationDto item)

        {
            repository.UpdateItem(id, mapper.Map<Donation>(item));
        }
    }
}








