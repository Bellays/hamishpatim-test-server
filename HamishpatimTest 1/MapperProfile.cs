using AutoMapper;
using HamishpatimTest_1.Models;

namespace HamishpatimTest_1
{
    public class MapperProfile:Profile
    {
            public MapperProfile()
            {
                CreateMap<Donation, DonationDto>().ReverseMap();
            
            }
        }
    }




