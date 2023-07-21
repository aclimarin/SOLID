namespace ISP.Initial;

public interface IATMTransaction
{
    void RequestDepositAmount(BankAccount bankAccount, double value);
    void RequestWithdrawalAmount(BankAccount bankAccount, double value);
    void RequestTransferAmount(BankAccount bankAccount, double value);
    void InformInsufficientFounds();
}