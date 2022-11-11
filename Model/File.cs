using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("File")]
    public class File : IdentityObject
    {
        public byte[] Byte { get; set; }

        public string Extension { get; set; }

        public string Name { get; set; }

        public Int64 Length { get; set; }
    }
}