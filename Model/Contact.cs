using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Contact")]
    public class Contact : IdentityObject
    {
        public string Email { get; set; }

        public string CellPhone { get; set; }

        public bool Whatsapp { set; get; }

        public string FixePhone { get; set; }
    }
}