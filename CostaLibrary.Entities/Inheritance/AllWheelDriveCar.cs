namespace CostaLibrary.Entities.Inheritance
{
    public abstract class AllWheelDriveCar : Car
    {
        public override void Accelerate(double kph)
        {
            this.FrontLeft.Rotate(kph);
            this.FrontRight.Rotate(kph);
            this.RearLeft.Rotate(kph);
            this.RearRight.Rotate(kph);
        }
    }
}