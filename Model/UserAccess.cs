using Function;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [GenericController(NameController = "UserAccess", NameDbSet = "UserAccess")]
    [Table("UserAccess")]
    [IgnoreLog]
    public class UserAccess : IdentityObject
    {
        public Guid UserID { get; set; }

        public DateTime Date { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public string Parameter { get; set; }

        public string DataModel { get; set; }

        public string IP { get; set; }

        public string Path { get; set; }

        public string URL { get; set; }
    }
}