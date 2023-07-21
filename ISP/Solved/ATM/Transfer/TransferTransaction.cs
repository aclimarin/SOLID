namespace ISP.Solved;

public class TransferTransaction: ITranferTransaction
{
    public void RequestTransferAmount(BankAccount bankAccount, double value)
    {
        /* ... */
        bankAccount.Amount += value;
    }
}