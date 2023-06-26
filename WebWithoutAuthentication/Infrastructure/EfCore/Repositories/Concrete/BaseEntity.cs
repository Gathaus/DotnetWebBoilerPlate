using WebWithoutAuthentication.Infrastructure.EfCore.Repositories.Abstract;

namespace WebWithoutAuthentication.Infrastructure.EfCore.Repositories.Concrete;

public class BaseEntity :IEntity
{
    public int Id { get; set; }
    public int? ModifiedById { get; set; }
    public int? CreatedById { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }

    public bool IsDeleted { get; set; }
}