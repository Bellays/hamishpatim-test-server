using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HamishpatimTest_1.Models
{
    public class Donation
    {
            public int Id { get; set; }
            public string? Donor { get; set; }
            public int Amount { get; set; }
            public string? DonorType { get; set; }
            public string? Purpose { get; set; }
            public string? Conditions { get; set; }
            public string? Currency { get; set; }
            public int ExchangeRate { get; set; }
        }





}

