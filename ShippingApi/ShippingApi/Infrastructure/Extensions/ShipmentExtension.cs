using ShippingApi.Infrastructure.Entities;

namespace ShippingApi.Infrastructure.Extensions
{
    public static class ShipmentExtension
    {
        public static IEnumerable<string> FetchBagNumbers(this Shipment shipment)
        {
            var bagNumbers = shipment.LetterBags?.Select(x => x.BagNumber).ToList();

            if (bagNumbers is null)
            {
                return shipment.ParcelBags?.Select(x => x.BagNumber).ToList() ?? new List<string>();
            }

            bagNumbers.AddRange(shipment.ParcelBags?.Select(x => x.BagNumber) ?? new List<string>());

            return bagNumbers;
        }
    }
}
