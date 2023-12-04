namespace DetarikA.S_API.Models.Entities
{
    public class Dealer : BaseEntity
    {
        public string ShippingAdress { get; set; }
        public string CompanyName { get; set; }

        //Relational Properties

        public virtual ICollection<Order> Orders { get; set; }
    }
}
