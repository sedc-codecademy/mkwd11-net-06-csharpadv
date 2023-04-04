namespace Domain
{
    public interface IMobileMessage
    {
        void SendSms(string number, string body);
    }
}
