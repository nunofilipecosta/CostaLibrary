namespace CostaLibrary.Entities.Inheritance
{
    public abstract class FrontWheelDriveCar : Car
    {
        public override void Accelerate(double kph)
        {
            this.FrontLeft.Rotate(kph);
            this.FrontRight.Rotate(kph);
        }
    }
}