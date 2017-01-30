namespace CostaLibrary.Entities.Composition
{
    public class TwoWheelDrive : IDriving
    {
        private readonly IWheel _left;
        private readonly IWheel _right;

        public TwoWheelDrive(IWheel left, IWheel right)
        {
            this._left = left;
            this._right = right;
        }

        public void Accelerate(double kph)
        {
            this._left.RotationSpeed += kph;
            this._right.RotationSpeed += kph;
        }
    }
}