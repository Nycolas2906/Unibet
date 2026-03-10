namespace UniBet.Entites
{
    public class Game : EntitiyBase
    {
        public string Name { get; set; }
        public string Provider { get; set; }

        public string Image { get; set; }  

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }

    }
}
