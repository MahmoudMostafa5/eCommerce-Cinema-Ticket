using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Producer
    {
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePicture { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relations
        public List<Movie> Movies { get; set; }
    }
}
