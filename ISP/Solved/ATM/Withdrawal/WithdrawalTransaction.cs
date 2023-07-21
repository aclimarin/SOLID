namespace ISP.Solved;

public class WithdrawalTransaction: IWithdrawalTransaction
{
    public void InformInsufficientFounds()
    {
        throw new Exception("Insufficient Founds!");
    }
    
    public void RequestWithdrawalAmount(BankAccount bankAccount, double value)
    {
        if (value > bankAccount.Amount)
            InformInsufficientFounds();
            
        bankAccount.Amount -= value;
    }
}