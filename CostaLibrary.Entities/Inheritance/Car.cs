namespace CostaLibrary.Entities.Inheritance
{
    public abstract class Car : BaseCar
    {
        protected Car()
        {
            this.FrontLeft = new Wheel();
            this.FrontRight = new Wheel();
            this.RearLeft = new Wheel();
            this.RearRight = new Wheel();
        }

        public override void TurnLeft(double degrees)
        {
            this.FrontLeft.TurnLeft(degrees);
            this.FrontRight.TurnLeft(degrees);
        }

        public override void TurnRight(double degrees)
        {
            this.FrontLeft.TurnRight(degrees);
            this.FrontRight.TurnRight(degrees);
        }
    }
}