namespace CostaLibrary.Entities.Inheritance
{
    public abstract class BaseCar
    {
        public Wheel FrontLeft { get; protected set; }

        public Wheel FrontRight { get; protected set; }

        public Wheel RearLeft { get; protected set; }

        public Wheel RearRight { get; protected set; }

        public abstract string Manufacturer { get; }

        public abstract void TurnLeft(double degrees);

        public abstract void TurnRight(double degrees);

        public abstract void Accelerate(double kmsPerHour);
    }
}