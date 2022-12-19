using AppTransaction.SharedModels;

namespace AppTransaction.Service;

public class WorkflowTransaction
{
    private Transaction[] Transaction;
    public WorkflowTransaction()
    {
        Transaction = new Transaction[2]
        {
            new Transaction(1,34, "Pokupka svetilnika", 100, DateTime.Now.AddDays(+1)),
            new Transaction(1999,15 , "Pokupka svetilnika", 600, DateTime.Now.AddDays(+1)),
        };
    }
    public void Show(User user)
    {
        bool check = true;
        for (int i = 0; i < Transaction.Length; i++)
        {
            if (Transaction[i].UserId == user.ID)
            {
                check = false;
                System.Console.WriteLine(Transaction[i]);
            }
            if (check == true)
            {
                System.Console.WriteLine("нет данных по транзакциям пользователя");
            }
        }
    }
}