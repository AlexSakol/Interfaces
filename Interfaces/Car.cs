
namespace Interfaces
{
    internal class Car : IGo
    {
        private double speed;
        private string? name;

        public Car() : this("Car", 2000, 60)
        {
        }

        public Car(string? name, int year, double speed)
        {
            Name = name;
            Year = year;
            Speed = speed;
        }

        public string? Name
        {
            get => name;
            set
            {
                if (value == null) name = "Car";
                else name = value;
            }
        }
        public int Year { get; set; }

        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value < 0) speed = 0;
                else speed = value;
            }
        }
        public void Go() => Console.WriteLine($"Скорость {this.speed}");
        public void Print() => Console.WriteLine($"{this.Name} едет по шоссе");
        public override string? ToString() => $"{Name} скорость {speed} год выпуска {Year}";
    }

}
