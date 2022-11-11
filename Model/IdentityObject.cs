using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class IdentityObject
    {
        //[IgnoreOnUpdate]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int RegId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual Guid ID { get; set; }
    }
}