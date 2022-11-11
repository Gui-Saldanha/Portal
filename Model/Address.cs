using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Address")]
    public class Address : IdentityObject
    {
        public int CodeIBGE { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string CEP { set; get; }
    }
}