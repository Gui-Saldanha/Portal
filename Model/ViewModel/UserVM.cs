using Constante;

namespace Model.ViewModel
{
    public class UserVM
    {
        public Guid UserID { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public PersonVM PersonVM { get; set; }
    }
}