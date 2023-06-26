using System.ComponentModel.DataAnnotations;

namespace WebWithoutAuthentication.Infrastructure.EfCore.Repositories.Abstract;

public interface IEntity : IHelperModel
{
    [Key] public int Id { get; set; }
}