namespace ShippingApi.Infrastructure.Entities
{
    public class ParcelBag : Bag
    {
        public virtual ICollection<Parcel> Parcels { get; set; }
    }
}
