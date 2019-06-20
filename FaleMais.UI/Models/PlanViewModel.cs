using FaleMais.Dominio.User.Entities;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FaleMais.UI.Models
{
    public class PlanViewModel
    {
        public Plan PlanEdit { get; set; }
        public AreaCodeSource AreaCodeSourceEdit { get; set; }
        public AreaCodeDestiny AreaCodeDestinyEdit { get; set; }

        public int Time { get; set; }
        [Required]
        public SelectList Source { get; set; }
        [Required]
        public SelectList Destiny { get; set; }
        [Required]
        public SelectList Plans { get; set; }

        [DataType(DataType.Currency)]
        public decimal Value { get; set; }

        [DataType(DataType.Currency)]
        public decimal ValueWith { get; set; }
    }
}