using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Actor
    {
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "ProfilePicture Is Required")]
        public string ProfilePicture { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name Is Required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Full Name Must be between 3 and 30 Chars")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography Is Required")] 
        public string Bio { get; set; }


        //Relation
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
