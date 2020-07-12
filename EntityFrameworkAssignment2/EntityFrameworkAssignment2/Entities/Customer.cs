using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkAssignment2.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [StringLength(30)]
        public string Cid { get; set; }
        [Required]
        public string Cname { get; set; }
        public string EmailID { get; set; }
        public int MobileNo { get; set; }
        public string City { get; set; }


    }
}
