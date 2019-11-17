using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Page.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name= "Insert your Name")]
        [Required(ErrorMessage = "Required"), StringLength(300, ErrorMessage = "Length can't be more than 300")]
        public string Name { get; set; }

        [Display(Name = "Insert your Surname")]
        [Required(ErrorMessage = "Required"), StringLength(300, ErrorMessage = "Length can't be more than 300")]
        public string Surname { get; set; }

        [Display(Name = "Insert your Address")]
        [Required(ErrorMessage = "Required"), StringLength(300, ErrorMessage = "Length can't be more than 300")]
        public string Address { get; set; }

        [Display(Name = "Insert your Phone")]
        [Required(ErrorMessage = "Required"), StringLength(300, ErrorMessage = "Length can't be more than 300")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name = "Insert your Email")]
        [Required(ErrorMessage = "Required"), StringLength(300, ErrorMessage = "Length can't be more than 300")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public DateTime OrderTime { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
