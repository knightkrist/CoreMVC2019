using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMVC2019.BaseModel
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string Street { get; set; }
        public string ATT { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public int CountryID { get; set; }
        [ForeignKey("CountryID")]
        public Country Country { get; set; }
    }
    public class Country
    {
        [Key]
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string CultureCode { get; set; }
        public int TelephoneCode { get; set; }
    }
}