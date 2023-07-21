namespace ISP.Initial;

public class WithdrawalTransaction: IATMTransaction
{
    public void InformInsufficientFounds()
    {
        throw new Exception("Insufficient Founds!");
    }

    public void RequestDepositAmount(BankAccount bankAccount, double value)
    {
        throw new NotImplementedException();
    }

    public void RequestTransferAmount(BankAccount bankAccount, double value)
    {
        throw new NotImplementedException();
    }

    public void RequestWithdrawalAmount(BankAccount bankAccount, double value)
    {
        if (value > bankAccount.Amount)
            InformInsufficientFounds();
            
        bankAccount.Amount -= value;
    }
}