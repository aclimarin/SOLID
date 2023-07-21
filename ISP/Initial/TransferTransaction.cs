namespace ISP.Initial;

public class TransferTransaction: IATMTransaction
{
    public void InformInsufficientFounds()
    {
        throw new NotImplementedException();
    }

    public void RequestDepositAmount(BankAccount bankAccount, double value)
    {
        throw new NotImplementedException();
    }

    public void RequestTransferAmount(BankAccount bankAccount, double value)
    {
        /* ... */
        bankAccount.Amount += value;
    }

    public void RequestWithdrawalAmount(BankAccount bankAccount, double value)
    {
        throw new NotImplementedException();
    }
}