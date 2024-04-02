﻿namespace SmartShelter_WebAPI.Models
{
    public class AviaryCondition
    {
        public int Id { get; set; }
        public float MinWater { get; set; }
        public float Food { get; set; }
        public float MinTemperature { get; set; }
        public float MaxTemperature { get; set; }
        public float MinHumidity { get; set; }
        public float MaxHumidity { get; set; }
        public int AviaryId { get; set; }


        public Aviary Aviary { get; set; }

    }
}
