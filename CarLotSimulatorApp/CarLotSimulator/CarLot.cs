using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public CarLot()
    {
        
    }

    public List<Car> Cars { get; set; } = new List<Car>();
    public static int NumberOfCars = 1;
}