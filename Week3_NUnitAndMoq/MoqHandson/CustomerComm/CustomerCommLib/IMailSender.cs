namespace CustomerCommLib;

public interface IMailSender
{
    bool SendMail(Customer customer);
}