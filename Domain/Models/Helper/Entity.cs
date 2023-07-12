namespace cjuridico.Domain.Models.Helper;

public class Entity
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; private set; }
}