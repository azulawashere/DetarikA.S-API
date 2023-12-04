using DetarikA.S_API.Models.Enums;

namespace DetarikA.S_API.Models.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Status = DataStatus.Inserted;
            CreatedDate = DateTime.UtcNow;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
