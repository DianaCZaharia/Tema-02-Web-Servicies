using Microsoft.AspNetCore.Mvc;
using TemaS2.Controllers.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TemaS2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        List<Car> cars = new List<Car>
        {
            new Car(1 ,"Focus","manual","Ford","2012"),
            new Car(2 ,"Sportage Suv","manual","Kia","2015"),
            new Car(3 ,"V50","automatic","Volvo","2009"),
            new Car(4 ,"Gle Amg","automatic","MercedesBenz","2017"),
            new Car(5 ,"A4 Navi","automatic","Audi","2011"),

        };
        // GET: api/Car
        [HttpGet]
        public List<Car> Get()
        {
            return cars;
        }

        // GET api/Car/5
        [HttpGet("{id}")]
        public Car Get(int id)
        {
            Car car = cars.Find(f => f.id == id);
            return car;
        }

        // POST api/Car
        [HttpPost]
        public List<Car> Post([FromBody] Car car)
        {
            cars.Add(car);
            return cars;
        }

        // PUT api/Car/5
        [HttpPut("{id}")]
        public List<Car> Put(int id, [FromBody] Car car)
        {

            Car carToUpdate = cars.Find(f => f.id == id);
            int index = cars.IndexOf(carToUpdate);

            cars[index].carModel = car.carModel;
            cars[index].carType = car.carType;
            cars[index].manufacturer = car.manufacturer;
            cars[index].dateOfRelease = car.dateOfRelease;

            return cars;
        }

        // DELETE api/Car/5
        [HttpDelete("{id}")]
        public List<Car> Delete(int id)
        {
            Car car = cars.Find(f => f.id == id);
            cars.Remove(car);
            return cars;
        }
    }
}
