namespace BLL
{
    public class CommunicationBL
    {
        public void AddSMS(string numberTo, Guid? DominioID, string sMensagem, Guid? EventoID, string UserId)
        {
            Comunica obj = new Comunica();
            obj.De = "Absis";
            obj.Para = sNumeroPara;
            obj.FormatoID = Config.FormatoComunica.Sms;
            obj.Assunto = "SMS";
            obj.DominioID = DominioID;
            obj.Mensagem = sMensagem;
            obj.EventoID = EventoID;
            Adiciona(obj, UserId, EventoID.GetValueOrDefault());
        }
    }
}