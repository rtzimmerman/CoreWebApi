using System;
namespace CoreWebAPI.Models
{
    public class CityDto
    {
        public int Id { get; set; }

        public string CityName { get; set; }

        public string State { get; set; }

        public int Population { get; set; }

        public string Description { get; set; }

        public int NumberOfPointsOfInterest { get; set; }
    }
}
