using PhoneBook2.Entity.Anstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2.Entity.Concrete
{
    [Table("AppUser")]
    public class AppUser : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string LastName { get; set; }

        public string FullName => Firstname + " " + LastName;
        public string PhoneNumber { get; set; }
        
    }
}
