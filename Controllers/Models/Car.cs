using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemaS2.Controllers.Models
{
    public class Car
    {
        public int id { get; set; }
        public string carModel { get; set; }
        public string carType { get; set; }
        public string manufacturer { get; set; }
        public string dateOfRelease { get; set; }

        public Car(int id, string carModel, string carType, string manufacturer, string dateOfRelease) : this(id)
        {
            this.carModel = carModel;
            this.carType = carType;
            this.manufacturer = manufacturer;
            this.dateOfRelease = dateOfRelease;
        }

        public Car(int id)
        {
            this.id = id;
        }
    }
}
