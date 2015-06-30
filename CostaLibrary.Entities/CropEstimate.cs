
namespace CostaLibrary.Entities
{
    using System;

    public class CropEstimate
    {
        public Guid CropEstimateId { get; set; }

        public string Name { get; set; }

        public bool IsValid { get; set; }
    }
}
