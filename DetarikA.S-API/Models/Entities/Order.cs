namespace DetarikA.S_API.Models.Entities
{
    public class Order : BaseEntity
    {       
        public decimal TotalPrice { get; set; }
        public int DealerID { get; set; }

        //Relational Properties
        public virtual Dealer Dealer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }


    }
}
