using Constante;

namespace Model
{
    public class Communication
    {
        public string From { get; set; }

        public string To { get; set; }

        public string CC { get; set; }

        public string CCO { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public string Attachment { get; set; }

        public DateTime Date { get; set; }

        public DateTime DateScheduled { get; set; }

        public DateTime? DateSent { get; set; }

        public DateTime? DateReturn { get; set; }

        public SituationCommunication Situation { get; set; }

        public User User { get; set; }

        public Guid UserID { get; set; }

        public string Return { get; set; }
    }
}
