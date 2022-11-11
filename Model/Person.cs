using Constante;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Person")]
    public class Person : IdentityObject
    {
        public File? Photo { get; set; }

        public Guid? PhotoID { get; set; }

        public string Name { get; set; }  

        public Address Address { get; set; }

        public Guid AddressID { get; set; }

        public Contact Contact { get; set; }

        public Guid ContactID { get; set; }

        public DateTime BirthDate { get; set; }

        public int BirthNation { get; set; }

        public int NationalityNation { get; set; }

        public Genr Genr { get; set; }

        public RaceColor RaceColor { get; set; }

        public CvilStatus CivilStatus { get; set; }

        public InstructionDegree InstructionDegree { get; set; }

        public TypePerson TypePerson { get; set; }

        public string RegistrationNumber { get; set; }
    }
}