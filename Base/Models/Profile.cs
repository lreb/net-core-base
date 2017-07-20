using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Base.Models.Identity;

namespace Base.Models
{
    public enum Genere
    {
        Men,
        Women,
        Other
    }

    public class Profile
    {
        public int Id { get; set; }
        [Display(Name = "display name")]
        public string DisplayName { get; set; }
        public DateTime BirthDate { get; set; }
        [Display(Name ="Profile picture")]
        public string ProfilePicture { get; set; }
        public Genere Genere { get; set; }

        public ApplicationUser User { get; set; }
    }
}
