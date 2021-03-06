﻿using Domain.Entities.Roles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.ViewModel.Cars
{
    public class ListAvailableCar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }
        public CarExchange Exchange { get; set; }
        public string Board { get; set; }
        public Double HourPrice { get; set; }
        public int LuggageCapacity { get; set; }
        public int TankCapacity { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public int Fuel { get; set; }
        public string Model { get; set; }
        public DateTime DateTimeExpectedNextCollected { get; set; }
        [JsonIgnore]
        public string Photos { get; set; }
        public string[] Images { get; set; }
    }
}
