# CarClassLab02

This is a C# project that contains two classes: `Car` and `TaxiCar`. The `Car` class is a simple representation of a car with a model, price, and service life. It has constructors, properties, methods, and operator overloading. The `TaxiCar` class is a subclass of `Car` that represents a taxi car with additional properties and methods.

## Car Class

### Properties

- `Model`: A string that represents the model of the car.
- `Price`: An unsigned integer that represents the price of the car.
- `ServiceLife`: An unsigned integer that represents the service life of the car in years.

### Constructors

- `Car()`: A default constructor that initializes the properties of the car to default values.
- `Car(string model, uint price, uint serviceLife)`: A constructor that initializes the properties of the car with the specified values.

### Methods

- `Equals(object obj)`: A method that compares two car objects for equality based on their model, price, and service life.
- `ToString()`: A method that returns a string representation of the car object.
- `ActualPrice`: A read-only property that returns the actual price of the car based on its price and service life.

### Operator Overloading

- `>`: A greater than operator that compares two car objects based on their price.
- `<`: A less than operator that compares two car objects based on their price.

## TaxiCar Class

### Properties

- `Company`: A string that represents the taxi company.
- `Coefficient`: A double that represents the coefficient of the taxi car.

### Constructors

- `TaxiCar()`: A default constructor that initializes the properties of the taxi car to default values.
- `TaxiCar(string model, uint price, uint serviceLife, string company, double coefficient)`: A constructor that initializes the properties of the taxi car with the specified values.
- `TaxiCar(Car car, string company, double coefficient)`: A constructor that initializes the properties of the taxi car with the properties of a car object and the specified values.

### Methods

- `ToString()`: A method that returns a string representation of the taxi car object.
- `TaxiPrice`: A read-only property that returns the taxi price of the taxi car based on its price, coefficient, and actual price.

