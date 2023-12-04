namespace DetarikA.S_API.Models.Entities
{
    public class OrderDetail : BaseEntity
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        //Relational Properties

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
