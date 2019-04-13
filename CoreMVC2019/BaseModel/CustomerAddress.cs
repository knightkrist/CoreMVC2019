using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMVC2019.BaseModel
{
    public class CustomerAddress
    {
        [Key]
        public int CustomerAddressID { get; set; }

        public int CustomerID { get; set; }

        public int AddressID { get; set; }

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        [ForeignKey("AddressID")]
        public Address Address { get; set; }
    }
}