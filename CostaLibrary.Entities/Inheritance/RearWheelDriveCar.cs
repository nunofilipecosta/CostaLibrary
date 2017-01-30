namespace CostaLibrary.Entities.Inheritance
{
    public abstract class RearWheelDriveCar : Car
    {
        public override void Accelerate(double kph)
        {
            this.RearLeft.Rotate(kph);
            this.RearRight.Rotate(kph);
        }
    }
}