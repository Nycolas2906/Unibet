namespace UniBet.Entites
{
    public class EntitiyBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? RemoveAt { get; set; }

        public EntitiyBase()
        {

        }
    }
}
