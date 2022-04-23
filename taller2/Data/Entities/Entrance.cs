using System.ComponentModel.DataAnnotations;

namespace taller2.Data
{
    public class Entrance
    {
        public int Id { get; set; } 
        public string Description { get; set; }

       
        public ICollection<Ticket> tickets { get; set; }

        [Display(Name = "entradas")]
        public int StatesNumber => tickets == null ? 0 : tickets.Count;
    }
}
