using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace halkhata.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Required(ErrorMessage ="Expense name is required")]
        [StringLength(100,ErrorMessage ="Expense name can't be longer than 100 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Expense amount is required")]
        public int Amount { get; set; }
        public String Details { get; set; }
        [ForeignKey("User")]
        [Required(ErrorMessage ="Expense must have an user")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}