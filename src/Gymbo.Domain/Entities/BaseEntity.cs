namespace Gymbo.Domain.Entities
{
    /// <summary>
    /// Base entity which all other entities (models) stem from.
    /// </summary>
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
