using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace halkhata.Models
{
    public class User
    {
        public int Id { get; set; }
        [StringLength(255,ErrorMessage = "Password can't be longer than 255 characters")]
        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }
        [StringLength(100, ErrorMessage= "Username can't be longer than 100 characters")]
        [DisplayName("Username")]
        [Required(ErrorMessage ="Username is required")]
        public string UserName { get; set; }

        [StringLength(100,ErrorMessage = "Email can't be longer than 100 characters")]
        [Required(ErrorMessage ="Email is required")]

        public string Email { get; set; }

        [ForeignKey("Team")]
        [Required(ErrorMessage ="Must be a member of a team")]
        public int TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
}