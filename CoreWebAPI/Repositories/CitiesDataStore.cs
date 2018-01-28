using System;
using System.Collections.Generic;
using CoreWebAPI.Models;

namespace CoreWebAPI
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            //init dummy data
            this.Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    CityName = "Denver",
                    State = "CO",
                    Population = 1000000,
                    Description = "Mile High City"
                },
                new CityDto()
                {
                    Id = 2,
                    CityName = "Chicago",
                    State = "IL",
                    Population = 9000050,
                    Description = "The Windy City"
                },
                new CityDto()
                {
                    Id = 3,
                    CityName = "Seattle",
                    State = "WA", 
                    Population = 4300500,
                    Description = "The Emerald City"
                }
            };
        }
    }
}
