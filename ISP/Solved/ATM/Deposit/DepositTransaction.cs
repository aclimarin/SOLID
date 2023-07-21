namespace ISP.Solved;

public class DepositTransaction : IDepositTransaction
{
    public void RequestDepositAmount(BankAccount bankAccount, double value)
    {
        /* ... */
        bankAccount.Amount += value;
    }
}