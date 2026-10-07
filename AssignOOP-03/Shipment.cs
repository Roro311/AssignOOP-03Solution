

namespace AssignOOP_03
{
    public class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        public string TrackingCode
        {
            get { return trackingCode; }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public DeliveryAddress Destination { get; set; }

        // Estimated Cost
        public virtual decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }

        // Constructor
        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            this.trackingCode = trackingCode;
            this.description = description;
            this.weight = weight;
            this.deliveryFee = deliveryFee;
            Destination = destination;
        }

        // =========================================
        // Update Delivery Fee
        // =========================================

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        // =========================================
        // UpdateWeight - Overload 1
        // =========================================

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }
        }

        // =========================================
        // UpdateWeight - Overload 2
        // =========================================

        public void UpdateWeight(decimal newWeight, decimal packingWeight)
        {
            decimal finalWeight = newWeight + packingWeight;

            if (finalWeight > 0)
            {
                Weight = finalWeight;
            }
        }

        // =========================================
        // PrintShipment
        // =========================================

        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Weight : {Weight} KG");
            Console.WriteLine($"Delivery Fee : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
        }
    }
}
