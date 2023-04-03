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

## How CompareTo Works

The `CompareTo` method is part of the non-generic `IComparable` interface implementation in the `Car` and `TaxiCar` classes. This method allows you to compare two objects of the same type and determine their relative order in a sorted list or array.

### Car Class

In the `Car` class, the comparison is done based on the following attributes, in order:

1. Model
2. Price
3. Service life

If the `Model` property is different between two instances, they will be sorted alphabetically based on the model name. If the models are the same, the instances will be sorted based on the `Price` property, from lowest to highest. If the prices are the same, the instances will be sorted based on the `ServiceLife` property, from lowest to highest.

### TaxiCar Class

In the `TaxiCar` class, which inherits from the `Car` class, the comparison includes additional attributes, in the following order:

1. Model (inherited from `Car`)
2. Price (inherited from `Car`)
3. Service life (inherited from `Car`)
4. Company
5. Coefficient

The first three attributes are compared in the same way as in the `Car` class. If these attributes are the same between two `TaxiCar` instances, they will be sorted alphabetically based on the `Company` property. If the companies are the same, the instances will be sorted based on the `Coefficient` property, from lowest to highest.


## Events Implementation

The `TechnicalInspectionNeeded` event is raised when the `ServiceLife` property of a `Car` is increased by one year. This event is implemented using a delegate `TechnicalInspectionNeededHandler` and an event handler `OnTechnicalInspectionNeeded`. This event allows other objects to be notified when a technical inspection is needed for the car.

The `PriceChanged` event is raised whenever the `Price` property of a `Car` is changed. This event is implemented using a delegate `PriceChangedHandler` and an event handler `OnPriceChanged`. This event allows other objects to be notified when the price of the car changes.

The `TaxiCar` class also uses events inherited from its parent class `Car`.
