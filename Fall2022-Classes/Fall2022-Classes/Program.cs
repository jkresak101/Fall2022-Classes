using Fall2022_Classes;

Car ashleysCar = new Car();

Console.WriteLine("Ashley has a "+ ashleysCar.Make);

ashleysCar.IsPaidFor = true;

Console.WriteLine("This car is paid for? : " + ashleysCar.IsPaidFor);

var gavCarMake = "Toyota";

Car gavinsCar = new Car(gavCarMake, "Camry", "Grey", 2007);
Console.WriteLine("Gavin has a " + gavinsCar.Make);

//making a list of objects from our new class
var garage = new List<Car>();

garage.Add(gavinsCar);
garage.Add(ashleysCar);

Console.WriteLine(garage[0].Model);