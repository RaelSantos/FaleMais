using FaleMais.Dominio.User.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Models
{
    public class PlanoViewModel
    {
        public Plan PlanEdit { get; set; }
        public AreaCode AreaCodeEdit { get; set; }

        public int Time { get; set; }
        [Required]
        public SelectList Source { get; set; }
        [Required]
        public SelectList Destiny { get; set; }
        [Required]
        public SelectList Plans { get; set; }

        [DataType(DataType.Currency)]
        public decimal ValueWithOutPlan { get; set; }

        [DataType(DataType.Currency)]
        public decimal ValueWithPlan { get; set; }
    }
}