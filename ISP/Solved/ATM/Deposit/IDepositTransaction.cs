namespace ISP.Solved;

public interface IDepositTransaction
{
    void RequestDepositAmount(BankAccount bankAccount, double value);    
}