using System.ComponentModel.DataAnnotations;

namespace FaleMais.Dominio.User.Entities
{
    public class Plan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Minute { get; set; }
    }
}
