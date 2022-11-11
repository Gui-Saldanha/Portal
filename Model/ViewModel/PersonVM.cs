using Constante;

namespace Model
{
    public class PersonVM
    {
        public FileVM? PhotoVM { get; set; }

        public Guid? PhotoVMID { get; set; }

        public string Name { get; set; }  

        public AddressVM AddressVM { get; set; }

        public Guid AddressVMID { get; set; }

        public ContactVM ContactVM { get; set; }

        public Guid ContactVMID { get; set; }

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