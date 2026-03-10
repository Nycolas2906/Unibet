

namespace UniBet.Entites
{
    public class Deposit : EntitiyBase
    {

        public float DepositAmount { get; set; }
        public string Deposittype { get; set; }
        public int UserId { get; set; }
        public DateTime Datetime { get; set; }
    }
}
