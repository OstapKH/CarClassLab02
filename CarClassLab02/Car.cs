namespace CarClassLab02;

public class Car
{
    private String model;
    private uint price;
    private uint serviceLife;

    public Car()
    {
        this.model = "Default model";
        this.price = 0;
        this.serviceLife = 0;
    }
    
    public Car(string model, uint price, uint serviceLife)
    {
        this.model = model;
        this.price = price;
        this.serviceLife = serviceLife;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Car other = (Car)obj;
        return this.model == other.model && this.price == other.price && this.serviceLife == other.serviceLife;
    }
    
    public static bool operator ==(Car leftCar, Car rightCar)
    {
        if (ReferenceEquals(leftCar, null))
        {
            return ReferenceEquals(rightCar, null);
        }
        return leftCar.Equals(rightCar);
    }

    public static bool operator !=(Car leftCar, Car rightCar)
    {
        return !(leftCar == rightCar);
    }

    public override string ToString()
    {
        return $"Model: {model}\nPrice: {price}\nService life: {serviceLife} y.\n";
    }

    public static bool operator >(Car leftCar, Car rightCar)
    {
        return leftCar.price > rightCar.price;
    }
    
    public static bool operator <(Car leftCar, Car rightCar) {
        return leftCar.price < rightCar.price;
    }
    
    public double ActualPrice
    {
        get
        {
            return price * Math.Pow((0.9), serviceLife);
        }
    }
    
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }

    public uint Price{
        get
        {
            return this.price;
        }
    }
    
    public uint ServiceLife{
        get
        {
            return this.serviceLife;
        }
        set
        {
            this.serviceLife = value;
        }
    }
}

public class TaxiCar : Car
{
    private string company;
    private double coefficient;

    public TaxiCar() : this(new Car(), "Default company", 1.0)
    {
        
    }

    public TaxiCar(string model, uint price, uint serviceLife, string company, double coefficient) : base(model, price, serviceLife)
    {
        this.company = company;
        this.coefficient = coefficient;
    }
    
    public TaxiCar(Car car, string company, double coefficient) : base(car.Model, car.Price, car.ServiceLife)
    {
        this.company = company;
        this.coefficient = coefficient;
    }
    
    public double TaxiPrice
    {
        get
        {
            return base.Price * Math.Pow((this.coefficient*10), base.ActualPrice);
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"Company: {company}\nCoefficient: {coefficient}\n";
    }
}