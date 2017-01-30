namespace CostaLibrary.Entities.Composition
{
    public class FrontSteering : ISteering
    {
        private readonly IWheel _frontLeft;
        private readonly IWheel _frontRight;

        public FrontSteering(IWheel frontLeft, IWheel frontRight)
        {
            this._frontLeft = frontLeft;
            this._frontRight = frontRight;
        }

        public void TurnLeft(double degrees)
        {
            this._frontLeft.Angle -= degrees;
            this._frontRight.Angle -= degrees;
        }

        public void TurnRight(double degrees)
        {
            this._frontLeft.Angle += degrees;
            this._frontRight.Angle += degrees;
        }
    }
}