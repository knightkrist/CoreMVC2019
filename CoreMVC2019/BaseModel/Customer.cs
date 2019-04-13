using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC2019.BaseModel
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HASH { get; set; }
        public string SALT { get; set; }
        public int CustomerAddressID { get; set; }

        [ForeignKey("CustomerAddressID")]
        public virtual ICollection<CustomerAddress> Addresses { get; set; }
    }
}
