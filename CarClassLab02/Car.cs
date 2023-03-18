namespace CarClassLab02;

public class Car: IFormattable
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
       public override string ToString()
    {
        return $"Model: {model}\nPrice: {price}\nService life: {serviceLife} y.\n";
    }
    
    public string ToString(string format, IFormatProvider formatProvider)
    {
        if (format == null)
        {
            return ToString();
        }

        switch (format.ToUpper())
        {
            case "P":
                return $"Price: {price}";
            case "SL":
                return $"Service life: {serviceLife} y.";
            case "M": 
                return $"Model: {model}";
            case "F":
                return $"Model: {model}, Price: {price}, Service life: {serviceLife} y.";
            case "MP":
                return $"Model: {model}, Price: {price}";
            default:
                throw new FormatException($"The {format} format string is not supported.");
        }
    }
}

public class TaxiCar : Car, IFormattable
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
    
    public string ToString(string format, IFormatProvider formatProvider)
    {
        if (format == null)
        {
            return ToString();
        }

        switch (format.ToUpper())
        {
            case "P":
                return $"Taxi price: {TaxiPrice}";
            case "M":
                return $"Taxi model: {Model}\nCompany: {company}";
            case "PM":
                return $"Taxi price: {TaxiPrice}\nTaxi model: {Model}";
            case "PMC":
                return $"Taxi price: {TaxiPrice}\nTaxi model: {Model}\nCompany: {company}";
            default:
                throw new FormatException($"The {format} format string is not supported.");
        }
    }
}