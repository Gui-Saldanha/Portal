using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("User")]
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public Person Person { get; set; }

        public Guid PersonID { get; set; }
    }
}