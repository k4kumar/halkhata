using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace halkhata.Models
{
    public class Team
    {
        public int Id { get; set; }
        [StringLength(100,ErrorMessage ="Team name can't be longer than 100 characters")]
        [Required(ErrorMessage ="Team name is required")]
        public string Name { get; set; }
    }
}