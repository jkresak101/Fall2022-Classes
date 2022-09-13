using Fall2022_Classes;
//creating a car with out defaults constructor
Car ashleysCar = new Car();

Console.WriteLine("Ashley has a "+ ashleysCar.Make);

ashleysCar.IsPaidFor = true;

Console.WriteLine("This car is paid for? : " + ashleysCar.IsPaidFor);

var gavCarMake = "Toyota";
//creating another car with another constructor
Car gavinsCar = new Car(gavCarMake, "Camry", "Grey", 2007);
Console.WriteLine("Gavin has a " + gavinsCar.Make);

//making a list of objects from our new class
var garage = new List<Car>();
//adding cars to list
garage.Add(gavinsCar);
garage.Add(ashleysCar);

Console.WriteLine(garage[0].Model);

// see the effects of the Accelerate method
//speed by defualt is 0
Console.WriteLine(gavinsCar.Speed);
gavinsCar.Accelerate(); // up to 5 from 0
Console.WriteLine(gavinsCar.Speed);
gavinsCar.Accelerate(); // up to 10 from 5
Console.WriteLine(gavinsCar.Speed);
//use of our overload Accelerate method
gavinsCar.Accelerate(7); // up to 17 from 10
Console.WriteLine(gavinsCar.Speed);
Console.WriteLine(gavinsCar.TimeToTravelDistance(500));

//Calling our static method from Car.cs
//this only works by calling the class, not an instance of the class
Car.Honk();

