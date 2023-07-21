namespace ISP.Solved;

public interface IWithdrawalTransaction
{
    void RequestWithdrawalAmount(BankAccount bankAccount, double value);    
    void InformInsufficientFounds();
}