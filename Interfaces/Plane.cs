
namespace Interfaces
{
    internal class Plane : IGo, IFly, IComparable<Plane>, IComparer<Plane>
    {
        private double speedFly;
        private double speedGo;
        private string? name;

        public Plane(string? name, int year, double speedFly, double speedGo)
        {
            Name = name;
            Year = year;
            SpeedFly = speedFly;
            SpeedGo = speedGo;
        }

        public Plane() : this(null, 1990, 800, 30)
        {
        }

        public string? Name
        {
            get => name;
            set
            {
                if (value is null) name = "Plane";
                else name = value;
            }
        }
        public int Year { get; set; }
        public double SpeedFly
        {
            get => speedFly;
            set
            {
                if (value < 0) speedFly = 0;
                else speedFly = value;
            }
        }
        public double SpeedGo
        {
            get => speedGo;
            set
            {
                if (value < 0) speedGo = 0;
                else speedGo = value;
            }
        }

        public void Fly() => Console.WriteLine($"{Name} летит со скоростью {this.SpeedFly}");


        public void Go() => Console.WriteLine($"{Name} едет по полосе со скоростью {this.SpeedGo}");

        public void Print() // склеивание
        {
            Console.WriteLine($"{Name} летает и едет по полосе");
        }

        void IFly.Print() // кастинг
        {
            Console.WriteLine($"{Name} летит");
        }
        void IGo.Print() // кастинг
        {
            Console.WriteLine($"{Name} едет по полосе");
        }

        public void IFlyPrint() // обертывание
        {
            ((IFly)this).Print();
        }
        public int CompareTo(Plane? other)
        {
            if (other == null) Console.WriteLine("Недопустимое значение");
            return Name.CompareTo(other.Name);
        }

        public int Compare(Plane? x, Plane? y)
        {
            if (x == null | y == null) Console.WriteLine("Недопустимое значение");
            return x.Year - y.Year;
        }
        public int CompareSecond(Plane? x, Plane? y)
        {
            if (x == null | y == null) Console.WriteLine("Недопустимое значение");
            if (x.SpeedFly < y.SpeedFly) return -1;
            else if (x.SpeedFly > y.SpeedFly) return 1;
            else return 0;
        }

        public override string? ToString() => $"{Name} скорость полета {speedFly} скорость на полосе {SpeedGo} год выпуска {Year}";
    }

}
