using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    //class Animal
    //{
    //    public string name { get; set; }
    //    public Animal() { }
    //    public Animal(string name) { this.name = name; }

    //    public void Run ()
    //    {
    //        Console.WriteLine($"{name}  is running! ");
    //    }
    //}

    //class Dog : Animal
    //{
    //    public Dog () { }
    //}

    //class uyKuchugi : Dog
    //{

    //}

    //class Cat : Animal
    //{
    //    public Cat(string name) : base(name)
    //    {

    //    }
        
    //}

    /// Cars
    class Car
    {
        public string model { get; set; }
        public decimal price { get; set; }


        public Car (string model, decimal price)
        {
            this.model = model;
            this.price = price;
        }

        public void Model() { Console.WriteLine($" Car model is {model}"); }
        public void Price() { Console.WriteLine($" Car price is {price}$"); }
        public void Drive()
        {Console.WriteLine($" {model} is riding !");}
    }

    class ExpensiveCar : Car
    {
        public double battery { get; set; }
        public ExpensiveCar(string model, decimal price, double battery) : base(model, price)
        {this.battery = battery;}

        public void BateryRasxod ()
        {Console.WriteLine($" {battery} km ga yetadi!");}
    }

    class Tesla : ExpensiveCar
    {
        public double version { get; set; }
        public Tesla(string model, decimal price, double battery, double version) 
            : base (model, price, battery)
        { this.version = version; }
        public void Version()
        {Console.WriteLine($" {version} - version ");}
    }

    class TeslaX : Tesla
    {
        public int xNumber { get; set; }
        public TeslaX(string model, decimal price, double battery, double version, int xNumber) 
            : base(model, price, battery, version)
        { this.xNumber = xNumber; }
        public void xNumbFunc()
        {Console.WriteLine($"{xNumber} X version number!");}
    }
    class CheepCar : Car
    {
        public double oil { get; set; }
        public CheepCar(string model, decimal price,double oil) : base(model, price)
        {this.oil = oil;}
        public void OilRasxod()
        {Console.WriteLine($" 100 kmga {oil} yoqilg'i yeydi!");}
    }
    class GM : CheepCar
    {
        public string absTormoz { get; set; }

        public GM(string model, decimal price, double oil, string absTormoz) : base(model, price, oil)
        {this.absTormoz = absTormoz;}

        public void AbsTormozFunc()
        {
            Console.WriteLine($" {model} mashisida  ABS tormoz {absTormoz}");
        }
    }
    public static void Main(string[] args)
    {
        //Dog dog = new Dog();
        //dog.name = " Alabay";
        //dog.Run();

        //Cat cat = new Cat(" Kis kis");
        //cat.Run();


        ExpensiveCar exCar = new ExpensiveCar(" Elektro mobile ", 40000, 500);
        exCar.Model();
        exCar.Price();
        exCar.BateryRasxod();

        Console.WriteLine();

        // Tesla
        Tesla tesla = new Tesla("ModelX", 50000, 550, 2);
        tesla.Model();
        tesla.Price();
        tesla.BateryRasxod();
        tesla.Version();
        /// GM
        GM gentra = new GM(" Gentra", 18000, 11, " Yo'q");
        gentra.Model();
        gentra.Price();
        gentra.OilRasxod();
        gentra.AbsTormozFunc();



    }
}
